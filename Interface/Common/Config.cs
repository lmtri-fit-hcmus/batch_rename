﻿using System.Collections.Generic;
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
                new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_PASCAL_CASE },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_PASCAL_CASE },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_PASCAL_CASE_NAME }
                },
                new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_NAME }
                },new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_REPLACE_CHARACTERS },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_REPLACE_CHARACTERS },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_REPLACE_CHARACTERS_NAME }
                },
                // Add more entries for

                // entry for add suffix counter plugin
                new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_ADD_SUFFIX_COUNTER },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_ADD_SUFFIX_COUNTER },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_ADD_SUFFIX_COUNTER_NAME }
                },
                // entry for add suffix plugin
                new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_ADD_SUFFIX },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_ADD_SUFFIX },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_ADD_SUFFIX_NAME }
                },
                // entry for change extension plugin
                new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_CHANGE_EXTENSION },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_CHANGE_EXTENSION },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_CHANGE_EXTENSION_NAME }
                },
                // entry for lowercase and remove space plugin
                new  Dictionary<string, object>
                {
                    { BrConstants.BR_KEY_FIRST_MID, BrMethods.BR_MID_START_LOWERCASE_AND_REMOVE_SPACE },
                    { BrConstants.BR_KEY_LAST_MID,  BrMethods.BR_MID_END_LOWERCASE_AND_REMOVE_SPACE },
                    { BrConstants.BR_KEY_NAME,    BrMethods.BR_LOWERCASE_AND_REMOVE_SPACE_NAME }
                },
            };
        }
    }
}

