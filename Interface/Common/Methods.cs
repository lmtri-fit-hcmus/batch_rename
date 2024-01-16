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
        public const int BR_MID_TEAR_DOWN                       = 0;
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
        // Implement here
    }
}