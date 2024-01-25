using BatchRename;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatchRename
{
    public class Instance
    {
        //instance map (map each plugin module with its own name)
        private static Dictionary<string, IPlugin> _instanceMap = new Dictionary<string, IPlugin>();
        private IPlugin _pluginInfo = null;
        Instance(IPlugin instance_infor)
        {
            _pluginInfo = instance_infor;
        }

        static public Instance CreateInstance(string pluginName)
        {
            // build before run/ debug
            // var exeFolder = AppDomain.CurrentDomain.BaseDirectory;
            var exeFolder = "D:\\DEADLINE\\SoftwareArchitecture\\doan\\batch_rename\\" + pluginName + "\\bin\\Debug\\net6.0-windows"; //hard code dll folder for debugging
            var dlls = new DirectoryInfo(exeFolder).GetFiles(pluginName + ".dll");
            if (dlls.Length == 0)
            {
                //can not load dll
                return null;
            }
            var types = Assembly.LoadFile(dlls[0].FullName).GetTypes(); ;

            foreach (var type in types)
            {
                if (type.IsClass)
                {
                    if (typeof(IPlugin).IsAssignableFrom(type))
                    {
                        var out_plugin = Activator.CreateInstance(type) as IPlugin;
                        var out_inst = new Instance(out_plugin);
                        return out_inst;
                    }
                }
            }
            //generate instance failed
            return null;
        }
        
        //handle <name>, <input> request
        public object handle(Request input, string name)
        {
            //If instance is generated => Pass to its plugin handle
            if (_instanceMap.ContainsKey(name))
            {
                return _instanceMap[name].Handle(input);
            }
            //If instance does not generated correctly
            if (_pluginInfo == null)
                return false;
            // Add plugin to instance
            _instanceMap.Add(name, _pluginInfo);
            return _instanceMap[name].Handle(input);
        }

        // Function to teardown all plugin
        public bool teardown()
        {
            Request item = new Request();
            item.m_mid = BrMethods.BR_MID_TEAR_DOWN;

            //Pass tear down request to all plugin
            foreach (var val in _instanceMap)
            {
                val.Value.Handle(item);
            }
            return true;
        }
    }
    
    //This class used for dispatch request from plugin manager to its plugin by METHOD_ID
    public class PluginDispatcher
    {
        private List<int> _first_mid_list        = new List<int>();
        private List<int> _last_mid_list         = new List<int>();
        private List<string> _plugin_name        = new List<string>();
        private List<Instance> _instance_list    = new List<Instance>();

        /*
         *  Load all module defined in config file.
        */
        public bool Config(List<Dictionary<string, object>> _inConfig)
        {
            for (int i = 0; i < _inConfig.Count; i++)
            {
                Dictionary<string, object> config = _inConfig[i];
                string name = config[BrConstants.BR_KEY_NAME].ToString();
                int first_mid = Convert.ToInt32(config[BrConstants.BR_KEY_FIRST_MID]);
                int last_mid = Convert.ToInt32(config[BrConstants.BR_KEY_LAST_MID]);

                _first_mid_list.Add(first_mid);
                _last_mid_list.Add(last_mid);
                _plugin_name.Add(name);
                _instance_list.Add(null);
            }

            return true;
        }
        //Dispatch request to its plugin
        public object Dispatch(Request input)
        {
            // Find its plugin by parsing method_id
            int plugin_idx = 0;
            for (; plugin_idx < _first_mid_list.Count; plugin_idx++)
            {
                if (input.m_mid < _first_mid_list[plugin_idx])
                {
                    break;
                }
            }
            if (--plugin_idx < 0)
            {
                return false; //out of range
            }
            if (_last_mid_list[plugin_idx] < input.m_mid)
            {
                return false; // method not support
            }

            // After find index of plugin => Pass this request to this plugin
         
            Instance ins = _instance_list[plugin_idx];
            //If plugin generated
            if (ins != null)
            {
                var name = _plugin_name[plugin_idx];
                return ins.handle(input, name);
            }
            //Else generate it
            Instance p_ins = Instance.CreateInstance(_plugin_name[plugin_idx]);
            if (p_ins == null)
            {
                return false; //unable to create instance    
            }
            _instance_list[plugin_idx] = p_ins;
            return _instance_list[plugin_idx].handle(input, _plugin_name[plugin_idx]);
        }

    }
    public class PluginManager : IPlugin
    {
        //return code of plugin
        static int g_plugin_rc               = 1;
        private PluginDispatcher _dispatcher = new PluginDispatcher();
        static PluginManager _instance = null;
        public PluginManager()
        {
            var configDict = PluginConfig.Get();
            if (!_dispatcher.Config(configDict))
            {
                g_plugin_rc = 0; // unable to set up plugin config
            }
        }
        public static PluginManager getInstance()
        {
            if (_instance == null)
            {
                _instance = new PluginManager();
            }
            return _instance;
        }
        public object Handle(Request input)
        {
            if(g_plugin_rc == 0)
            {
                return null; // dispatcher is not loaded config
            }
            //Dispatch to specticular plugin to handle request
            return _dispatcher.Dispatch(input);
        }

    }
}
