using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЗадачиНачалаРаботы:EnumBase
    {
        public ЗадачиНачалаРаботы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДоступКОрганизациям => GetProperty<EnumItem>("ДоступКОрганизациям");
        public EnumItem РеквизитыОрганизации => GetProperty<EnumItem>("РеквизитыОрганизации");
        public EnumItem ПараметрыУчета => GetProperty<EnumItem>("ПараметрыУчета");
        public EnumItem УчетнаяПолитика => GetProperty<EnumItem>("УчетнаяПолитика");
        public EnumItem НачальныеОстатки => GetProperty<EnumItem>("НачальныеОстатки");
    }
}
