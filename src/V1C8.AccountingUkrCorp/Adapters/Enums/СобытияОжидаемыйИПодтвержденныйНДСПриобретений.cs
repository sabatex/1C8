using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СобытияОжидаемыйИПодтвержденныйНДСПриобретений:V1C8COMObject
    {
        public СобытияОжидаемыйИПодтвержденныйНДСПриобретений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Поступление => GetProperty<EnumItemBase>();
        public EnumItemBase Возврат => GetProperty<EnumItemBase>();
    }
}
