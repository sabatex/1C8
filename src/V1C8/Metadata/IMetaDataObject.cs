using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObject:IMetaDataDescription
    {
        string FullName()=>Method<string>("FullName");
     }
   
}