using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Enums
{
    public class EnumTypeBase:V1C8COMObject
    {
        public EnumTypeBase(EnumsTypeBase owner, object handle) : base(owner, handle)
        {
        }

        public int  IndexOf(V1C8COMObject obj)=>MethodInt("IndexOf",obj);
        public int  Count(V1C8COMObject obj)=>MethodInt("Count",obj);
        
        public EnumItemBase Get(int index)=>Method<EnumItemBase>("Get",index);
        public EnumItemBase EmptyRef()=>Method<EnumItemBase>("EmptyRef"); 
    }

}