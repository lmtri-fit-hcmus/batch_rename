// Define methods for plugins

namespace BatchRename
{
    public static class BrConstants
    {
        // string const
        public const string BR_KEY_FIRST_MID    = "first_mid";
        public const string BR_KEY_LAST_MID     = "last_mid";
        public const string BR_KEY_PLUGIN       = "plugin";
        public const string BR_KEY_NAME         = "name";
        // Add more string constants as needed
    }

    public static class BrMethods
    {
        public const int BR_MID_FIRST_GENERAL                   = 0;
        public const int BR_MID_TEAR_DOWN                       = BR_MID_FIRST_GENERAL;
        public const int BR_MID_GET_PLUGINS_INFO                = BR_MID_FIRST_GENERAL + 1;
        public const int BR_MID_END_GENERAL                     = 99;
        /*
         * Plugin: Add Prefix 
         * Method range: 100-150
         */
        public const string BR_ADD_PREFIX_NAME                  = "AddPrefixRule";
        public const int BR_MID_START_ADD_PREFIX                = 100;
        public const int BR_MID_ADD_PREFIX_RULE                 = BR_MID_START_ADD_PREFIX;
        public const int BR_MID_ADD_PREFIX_RENAME               = BR_MID_START_ADD_PREFIX + 1;
        public const int BR_MID_ADD_PREFIX_ADD_RULE_CLICK       = BR_MID_START_ADD_PREFIX + 2;
        public const int BR_MID_END_ADD_PREFIX                  = 150;



        /*
         * Plugin: Add Suffix 
         * Method range: 151-200
         */

        /*
         * Plugin: Pascal Case
         * Method range: 351-400
         */
        public const string BR_PASCAL_CASE_NAME                 = "Pascal Case";
        public const int BR_MID_START_PASCAL_CASE               = 351;
        public const int BR_MID_PASCAL_CASE                     = BR_MID_START_PASCAL_CASE;
        public const int BR_MID_PASCAL_CASE_RENAME              = BR_MID_START_PASCAL_CASE + 1;
        public const int BR_MID_PASCAL_CASE_ADD_RULE_CLICK      = BR_MID_START_PASCAL_CASE + 2;
        public const int BR_MID_END_PASCAL_CASE                 = 400;

        /*
         * Plugin: Remove All Space From Begin And End
         * Method range: 401-450
         */
        public const string BR_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_NAME             = "Remove All Space From Begin And End";
        public const int BR_MID_START_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END           = 401;
        public const int BR_MID_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END                 = BR_MID_START_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END;
        public const int BR_MID_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_RENAME          = BR_MID_START_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END + 1;
        public const int BR_MID_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_ADD_RULE_CLICK  = BR_MID_START_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END + 2;
        public const int BR_MID_END_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END             = 450;

        /*
         * Plugin: Replace Characters
         * Method range: 451-500
         */
        public const string BR_REPLACE_CHARACTERS_NAME                              = "Replace Characters";
        public const int BR_MID_START_REPLACE_CHARACTERS                            = 451;
        public const int BR_MID_REPLACE_CHARACTERS                                  = BR_MID_START_REPLACE_CHARACTERS;
        public const int BR_MID_REPLACE_CHARACTERS_RENAME                           = BR_MID_START_REPLACE_CHARACTERS + 1;
        public const int BR_MID_REPLACE_CHARACTERS_ADD_RULE_CLICK                   = BR_MID_START_REPLACE_CHARACTERS + 2;
        public const int BR_MID_END_REPLACE_CHARACTERS                              = 500;
        // Implement here

        /*
         * Plugin: Add Suffix Counter
         * Method range: 501-550
         */
        #region ADD_SUFFIX_COUNTER_RULE
        public const string BR_ADD_SUFFIX_COUNTER_NAME = "AddSuffixCounterRule";
        public const int BR_MID_START_ADD_SUFFIX_COUNTER = 501;
        public const int BR_MID_ADD_SUFFIX_COUNTER_RULE = BR_MID_START_ADD_SUFFIX_COUNTER;
        public const int BR_MID_ADD_SUFFIX_COUNTER_RENAME = BR_MID_START_ADD_SUFFIX_COUNTER + 1;
        public const int BR_MID_ADD_SUFFIX_COUNTER_ADD_RULE_CLICK = BR_MID_START_ADD_SUFFIX_COUNTER + 2;
        public const int BR_MID_END_ADD_SUFFIX_COUNTER = 550;
        #endregion

        /*
         * Plugin: Add Suffix 
         * Method range: 551-600
         */
        #region ADD_SUFFIX_RULE
        public const string BR_ADD_SUFFIX_NAME = "AddSuffixRule";
        public const int BR_MID_START_ADD_SUFFIX = 551;
        public const int BR_MID_ADD_SUFFIX_RULE = BR_MID_START_ADD_SUFFIX;
        public const int BR_MID_ADD_SUFFIX_RENAME = BR_MID_START_ADD_SUFFIX + 1;
        public const int BR_MID_ADD_SUFFIX_ADD_RULE_CLICK = BR_MID_START_ADD_SUFFIX + 2;
        public const int BR_MID_END_ADD_SUFFIX = 600;
        #endregion

        /*
         * Plugin: Change Extension
         * Method range: 601-650
         */
        #region CHANGE_EXTENSION_RULE
        public const string BR_CHANGE_EXTENSION_NAME = "ChangeExtensionRule";
        public const int BR_MID_START_CHANGE_EXTENSION = 601;
        public const int BR_MID_CHANGE_EXTENSION_RULE = BR_MID_START_CHANGE_EXTENSION;
        public const int BR_MID_CHANGE_EXTENSION_RENAME = BR_MID_START_CHANGE_EXTENSION + 1;
        public const int BR_MID_CHANGE_EXTENSION_ADD_RULE_CLICK = BR_MID_START_CHANGE_EXTENSION + 2;
        public const int BR_MID_END_CHANGE_EXTENSION = 650;
        #endregion


        /*
         * Plugin: Lowercase and remove space
         * Method range: 651-700
         */
        #region LOWERCASE_AND_REMOVE_SPACE_RULE
        public const string BR_LOWERCASE_AND_REMOVE_SPACE_NAME = "LowercaseAndRemoveSpace";
        public const int BR_MID_START_LOWERCASE_AND_REMOVE_SPACE = 651;
        public const int BR_MID_LOWERCASE_AND_REMOVE_SPACE_RULE = BR_MID_START_LOWERCASE_AND_REMOVE_SPACE;
        public const int BR_MID_LOWERCASE_AND_REMOVE_SPACE_RENAME = BR_MID_START_LOWERCASE_AND_REMOVE_SPACE + 1;
        public const int BR_MID_LOWERCASE_AND_REMOVE_SPACE_ADD_RULE_CLICK = BR_MID_START_LOWERCASE_AND_REMOVE_SPACE + 2;
        public const int BR_MID_END_LOWERCASE_AND_REMOVE_SPACE = 700;
        #endregion
    }
}