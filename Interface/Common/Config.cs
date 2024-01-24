using System.Collections.Generic;
namespace BatchRename
{
    /*
        Config for plugins, define:
            - first method id (mid)
            - last method id
            - name of plugin
     */
    public static class PluginConfig
    {
        public static List<Dictionary<string, object>> Get()
        {
            return  new List<Dictionary<string, object>>
            {
                // entry for add prefix plugin
                new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_ADD_PREFIX },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_ADD_PREFIX },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_ADD_PREFIX_NAME }
                },
                // Add more entries for
            };
        }
    }
}

