using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияОжидаемыйИПодтвержденныйНДСПродаж:V1C8COMObject
    {
        public СобытияОжидаемыйИПодтвержденныйНДСПродаж(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Реализация => GetProperty<EnumItemBase>("Реализация");
        public EnumItemBase Возврат => GetProperty<EnumItemBase>("Возврат");
        public EnumItemBase РеализацияРозница => GetProperty<EnumItemBase>("РеализацияРозница");
        public EnumItemBase ВозвратРозница => GetProperty<EnumItemBase>("ВозвратРозница");
        public EnumItemBase УсловнаяПродажа => GetProperty<EnumItemBase>("УсловнаяПродажа");
        public EnumItemBase УсловнаяПродажаВозврат => GetProperty<EnumItemBase>("УсловнаяПродажаВозврат");
    }
}
