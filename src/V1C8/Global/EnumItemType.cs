using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Global
{
    public class EnumItemType:V1C8COMObject
    {
        public EnumItemType(V1C8COMObject owner, object handle) : base(owner, handle)
        {
        }
        public V1C8COMObject Metadata()=>Method<V1C8COMObject>("Metadata");
        public bool IsEmpty()=>Method<bool>("IsEmpty");
 
    }

}