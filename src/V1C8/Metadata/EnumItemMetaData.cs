using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Metadata
{
    public class EnumItemMetaData:MetaDataBase
    {
        public EnumItemMetaData(V1C8COMObject owner, object handle) : base(owner, handle)
        {
        }

        public bool  IsEmpty()=>MethodSruct<bool>("IsEmpty");
    }

}