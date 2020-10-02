using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.MetadataClasses;

namespace sabatex.V1C8
{
    public class Metadata 
    {
        dynamic rootCOMObject;
        dynamic metaDataCOMObject;
        internal Metadata(dynamic rootCOMObject)
        {
            this.rootCOMObject = rootCOMObject;
            this.metaDataCOMObject = rootCOMObject.Metadata;
            this.Enums = new Enums(metaDataCOMObject.Enums);
        }
        public string Name { get=>metaDataCOMObject.Name; }
        public string Version { get=>metaDataCOMObject.Version; }
        public readonly Enums Enums;

    }

    
}