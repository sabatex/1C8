using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObject:IV1C8Description
    {
        string FullName()=>Method<string>("FullName");
     }
   
}