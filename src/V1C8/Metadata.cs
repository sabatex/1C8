using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.MetadataClasses;

namespace sabatex.V1C8
{
    public class Metadata:IDisposable 
    {
        dynamic COMObject;
        internal Metadata(dynamic rootCOMObject)
        {
            this.COMObject = rootCOMObject;
        }
        public string Name { get=>COMObject.Metadata.Name; }
        public string Version { get=>COMObject.Metadata.Version; }
        public Enums Enums {get=>new Enums(COMObject);}

        public void Dispose()
        {
            COMObject = null;
        }
    }

    
}