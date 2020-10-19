using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КодыОперацийВзаиморасчетыСРаботникамиОрганизаций:V1C8COMObject
    {
        public КодыОперацийВзаиморасчетыСРаботникамиОрганизаций(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начисления => GetProperty<EnumItemBase>();
        public EnumItemBase Взносы => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>();
        public EnumItemBase Удержания => GetProperty<EnumItemBase>();
        public EnumItemBase Выплата => GetProperty<EnumItemBase>();
        public EnumItemBase ПереносКопеекНаСледующийМесяц => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьВыплатаАванса => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьВыплатаМежрасчетная => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьВыплатаОчередная => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьВыплатаДивидендов => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьВыплатаДепонента => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьПогашениеНачисленийПоФактуВыплаты => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьВключениеКопеекПредыдущегоМесяца => GetProperty<EnumItemBase>();
    }
}
