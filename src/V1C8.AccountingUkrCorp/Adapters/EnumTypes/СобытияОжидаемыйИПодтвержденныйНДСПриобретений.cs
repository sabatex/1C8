using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияОжидаемыйИПодтвержденныйНДСПриобретений:EnumBase
    {
        public СобытияОжидаемыйИПодтвержденныйНДСПриобретений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Поступление => GetProperty<EnumItem>("Поступление");
        public EnumItem Возврат => GetProperty<EnumItem>("Возврат");
    }
}
