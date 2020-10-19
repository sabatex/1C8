using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияОжидаемыйИПодтвержденныйНДСПриобретений:V1C8COMObject
    {
        public СобытияОжидаемыйИПодтвержденныйНДСПриобретений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Поступление => GetProperty<EnumItemBase>("Поступление");
        public EnumItemBase Возврат => GetProperty<EnumItemBase>("Возврат");
    }
}
