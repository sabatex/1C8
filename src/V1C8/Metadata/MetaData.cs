using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class MetaData:V1C8COMObject
    {
        public MetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public string Name { get=>GetPropertyString("Name");}
        public string Version { get => GetPropertyString("Version") ; }
        public V1C8COMObject FindByType(V1C8COMObject elementType)=>Method<V1C8COMObject>("FindByType",elementType);

        public Enums Enums{get=>GetProperty<Enums>("Enums");}

     }

    
}