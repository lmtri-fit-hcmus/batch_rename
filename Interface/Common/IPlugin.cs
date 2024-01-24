
using Interface;
using System;
using System.Collections.Generic;

namespace BatchRename
{
    //Param for each method of plugin
    public struct Request
    {
        // method id for each request
        public int m_mid { get; set; }

        // params for each request
        public Dictionary<string, object> m_params { get; set; }
    }

    //Plugin interface
    public interface IPlugin
    {
        public object Handle(Request input);
    }
}

