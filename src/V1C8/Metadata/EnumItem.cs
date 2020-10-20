using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.EnumTypes
{
    public class EnumItem:MetaDataBae
    {
        public EnumItem(EnumBase owner, object handle) : base(owner, handle)
        {
        }

        public bool  IsEmpty()=>MethodSruct<bool>("IsEmpty");
    }

}