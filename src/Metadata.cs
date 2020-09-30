using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8
{
    public class Metadata 
    {
        dynamic context;
        internal Metadata(dynamic context)
        {
            this.context = context;
        }
        public string Name { get=>context.Metadata.Name; }
        public string Version { get=>context.Metadata.Version; }

    }
}