using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияОжидаемыйИПодтвержденныйНДСПродаж:EnumBase
    {
        public СобытияОжидаемыйИПодтвержденныйНДСПродаж(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Реализация => GetProperty<EnumItem>("Реализация");
        public EnumItem Возврат => GetProperty<EnumItem>("Возврат");
        public EnumItem РеализацияРозница => GetProperty<EnumItem>("РеализацияРозница");
        public EnumItem ВозвратРозница => GetProperty<EnumItem>("ВозвратРозница");
        public EnumItem УсловнаяПродажа => GetProperty<EnumItem>("УсловнаяПродажа");
        public EnumItem УсловнаяПродажаВозврат => GetProperty<EnumItem>("УсловнаяПродажаВозврат");
    }
}
