using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.EnumTypes
{
    public class EnumBase:V1C8COMObject
    {
        public EnumBase(EnumsBase owner, object handle) : base(owner, handle)
        {
        }

        public int  IndexOf(V1C8COMObject obj)=>MethodInt("IndexOf",obj);
        public int  Count(V1C8COMObject obj)=>MethodInt("Count",obj);
        
        public EnumItem Get(int index)=>Method<EnumItem>("Get",index);
        public EnumItem EmptyRef()=>Method<EnumItem>("EmptyRef"); 
    }

}