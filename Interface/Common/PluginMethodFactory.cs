﻿using BatchRename;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Common
{
    public static class PluginRenameMethodFactory
    {
        private static Dictionary<string, int> br_mids = new Dictionary<string, int>
        {
            { BrMethods.BR_ADD_PREFIX_NAME, BrMethods.BR_MID_ADD_PREFIX_RENAME  },
            { BrMethods.BR_PASCAL_CASE_NAME, BrMethods.BR_MID_PASCAL_CASE_RENAME  },
            { BrMethods.BR_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_NAME, BrMethods.BR_MID_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_RENAME  },
            { BrMethods.BR_REPLACE_CHARACTERS_NAME, BrMethods.BR_MID_REPLACE_CHARACTERS_RENAME  },

        };

        public static int createMid(string ruleName)
        {
            ruleName = ruleName.Replace(" ", "");
            if (br_mids.ContainsKey(ruleName))
            { 
                return br_mids[ruleName];
            }

            return -1;
        }

    }

    public static class PluginCloneMethodFactory
    {
        private static Dictionary<string, int> br_mids = new Dictionary<string, int>
        {
            { BrMethods.BR_ADD_PREFIX_NAME, BrMethods.BR_MID_ADD_PREFIX_ADD_RULE_CLICK  },
            { BrMethods.BR_PASCAL_CASE_NAME, BrMethods.BR_MID_PASCAL_CASE_ADD_RULE_CLICK  },
            { BrMethods.BR_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_NAME, BrMethods.BR_MID_REMOVE_ALL_SPACE_FROM_BEGIN_AND_END_ADD_RULE_CLICK  },
            { BrMethods.BR_REPLACE_CHARACTERS_NAME, BrMethods.BR_MID_REPLACE_CHARACTERS_ADD_RULE_CLICK  },

        };

        public static int createMid(string ruleName)
        {
            ruleName = ruleName.Replace(" ", "");
            if (br_mids.ContainsKey(ruleName))
            {
                return br_mids[ruleName];
            }

            return -1;
        }

    }
}
