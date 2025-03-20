using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectEnumValue:IMetadataObject
    {
         public bool  IsEmpty()=>Method<bool>("IsEmpty");
    }

}