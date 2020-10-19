using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ЗадачиНачалаРаботы:V1C8COMObject
    {
        public ЗадачиНачалаРаботы(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоступКОрганизациям => GetProperty<EnumItemBase>();
        public EnumItemBase РеквизитыОрганизации => GetProperty<EnumItemBase>();
        public EnumItemBase ПараметрыУчета => GetProperty<EnumItemBase>();
        public EnumItemBase УчетнаяПолитика => GetProperty<EnumItemBase>();
        public EnumItemBase НачальныеОстатки => GetProperty<EnumItemBase>();
    }
}
