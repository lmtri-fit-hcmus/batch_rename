using Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BatchRename
{
    public class LowerCaseAndRemoveSpace : IPlugin
    {
        public object Handle(Request item)
        {
            switch (item.m_mid)
            {
                /*
                 * params: is_file, list, params(rule params)
                 * return []
                 * */
                case BrMethods.BR_MID_LOWERCASE_AND_REMOVE_SPACE_RENAME:
                    bool isFile = Convert.ToBoolean(item.m_params["is_file"]);
                    ObservableCollection<Item> list = item.m_params["list"] as ObservableCollection<Item>;
                    List<string> paramRule = item.m_params["params"] as List<string>;
                    _LowercaseAndRemoveSpace renameRule = new _LowercaseAndRemoveSpace();
                    renameRule.Parameter = paramRule;
                    renameRule.Rename(list, isFile);
                    break;
                /*
                * params: []
                * return: IRule with params (SHOULD NOT IMPLEMENT LIKE THAT BUT DO NOT FIND SOLUTION, EVERY WORKS RELATED TO IRULE, PASS TO PLUGIN MANAGER)
                * TEMPORARY IMPLEMENT
                * */
                case BrMethods.BR_MID_LOWERCASE_AND_REMOVE_SPACE_ADD_RULE_CLICK:
                    var cloneRule = new _LowercaseAndRemoveSpace();
                    if (cloneRule.isEditable())
                    {
                        if (cloneRule.showUI() == false)
                            return null;
                        return RuleFormatAdapter.changeToRuleFormat(cloneRule);
                    }
                    else if (cloneRule != null)
                        return RuleFormatAdapter.changeToRuleFormat(cloneRule);
                    return null;
                /*
                * params: []
                * return: bool
                */
                case BrMethods.BR_MID_LOWERCASE_AND_REMOVE_SPACE_IS_EDITABLE:
                    var _ = new _LowercaseAndRemoveSpace();
                    return _.isEditable();
            }
            return true;
        }

        private class _LowercaseAndRemoveSpace : IRule
        {
            public string ruleName { get; set; }
            public string ruleDescription { get; set; }
            public List<string> Parameter { get; set; }
            public string Replace { get; set; }
            public List<int> counter { get; set; }

            public _LowercaseAndRemoveSpace(string _rulename, string _ruleDescription, List<string> _parameter,
    string _replace, List<int> _counter)
            {
                ruleName = _rulename;
                ruleDescription = _ruleDescription;
                Parameter = _parameter;
                Replace = _replace;
                counter = _counter;
            }
            public bool isEditable()
            {
                return false;
            }
            public _LowercaseAndRemoveSpace()
            {
                ruleName = BrMethods.BR_LOWERCASE_AND_REMOVE_SPACE_NAME;
                ruleDescription = "change file name to lower and remove all spaces";
            }

            public IRule Clone()
            {
                _LowercaseAndRemoveSpace clone = new _LowercaseAndRemoveSpace();
                clone.Parameter = Parameter;
                return clone;
            }


            public void Rename(ObservableCollection<Item> list, bool isFile)
            {
                string result;
                for (int i = 0; i < list.Count; i++)
                {
                    string str = list[i].itemName;
                    if (isFile)
                    {
                        string[] strings = str.Split('.');
                        string fileName = "", extension = strings[^1];
                        if (strings.Length == 1)
                        {
                            fileName = str;
                            extension = "";
                        }
                        else
                        {
                            foreach (string s in strings)
                            {

                                if (Array.IndexOf(strings, s) == strings.Length - 1)
                                {
                                    fileName = fileName.Remove(fileName.Length - 1);
                                    break;
                                }
                                fileName = s + '.';
                            }
                        }
                        fileName = fileName.ToLower();
                        String[] par = fileName.Split(' ');
                        fileName = "";
                        for (int j = 0; j < par.Length; j++)
                        {
                            fileName = fileName + par[j];
                        }
                        result = fileName + '.' + extension;
                    }
                    else
                    {
                        str = str.ToLower();
                        String[] par = str.Split(' ');
                        str = "";
                        for (int j = 0; j < par.Length; j++)
                        {
                            str = str + par[j];
                        }
                        result = str + '.' + str;

                        result = str;
                    }

                    list[i].newItemName = result;
                }
            }

            public bool? showUI()
            {
                return false;
            }
        }
    }

    
}
