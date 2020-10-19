using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Enums
{
    public class EnumItemBase:V1C8COMObject
    {
        public EnumItemBase(EnumTypeBase owner, object handle) : base(owner, handle)
        {
        }

        public bool  IsEmpty()=>MethodSruct<bool>("IsEmpty");
    }

}