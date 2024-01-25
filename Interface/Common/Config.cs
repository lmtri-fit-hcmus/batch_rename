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
                    /* { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_PASCAL_CASE },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_PASCAL_CASE },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_PASCAL_CASE } */
                    { BrConstants.BR_KEY_FIRST_MID, 100 },
                    { BrConstants.BR_KEY_LAST_MID,  1000 },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_REPLACE_CHARACTERS }
                },
                // Add more entries for
            };
        }
    }
}

