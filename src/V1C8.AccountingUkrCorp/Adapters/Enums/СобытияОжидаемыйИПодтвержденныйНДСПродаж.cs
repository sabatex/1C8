using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СобытияОжидаемыйИПодтвержденныйНДСПродаж:V1C8COMObject
    {
        public СобытияОжидаемыйИПодтвержденныйНДСПродаж(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Реализация => GetProperty<EnumItemBase>();
        public EnumItemBase Возврат => GetProperty<EnumItemBase>();
        public EnumItemBase РеализацияРозница => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратРозница => GetProperty<EnumItemBase>();
        public EnumItemBase УсловнаяПродажа => GetProperty<EnumItemBase>();
        public EnumItemBase УсловнаяПродажаВозврат => GetProperty<EnumItemBase>();
    }
}
