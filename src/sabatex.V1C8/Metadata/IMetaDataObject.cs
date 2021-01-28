using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObject: IMetadataDescription
    {
        string FullName()=>Method<string>("FullName");
        public string Presentation() => Method<string>("Presentation");
    }
   
}