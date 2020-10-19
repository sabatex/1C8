using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЗадачиНачалаРаботы:V1C8COMObject
    {
        public ЗадачиНачалаРаботы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоступКОрганизациям => GetProperty<EnumItemBase>("ДоступКОрганизациям");
        public EnumItemBase РеквизитыОрганизации => GetProperty<EnumItemBase>("РеквизитыОрганизации");
        public EnumItemBase ПараметрыУчета => GetProperty<EnumItemBase>("ПараметрыУчета");
        public EnumItemBase УчетнаяПолитика => GetProperty<EnumItemBase>("УчетнаяПолитика");
        public EnumItemBase НачальныеОстатки => GetProperty<EnumItemBase>("НачальныеОстатки");
    }
}
