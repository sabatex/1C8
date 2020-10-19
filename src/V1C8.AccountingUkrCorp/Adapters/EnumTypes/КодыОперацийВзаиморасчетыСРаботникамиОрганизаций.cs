using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодыОперацийВзаиморасчетыСРаботникамиОрганизаций:V1C8COMObject
    {
        public КодыОперацийВзаиморасчетыСРаботникамиОрганизаций(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начисления => GetProperty<EnumItemBase>("Начисления");
        public EnumItemBase Взносы => GetProperty<EnumItemBase>("Взносы");
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>("НДФЛ");
        public EnumItemBase Удержания => GetProperty<EnumItemBase>("Удержания");
        public EnumItemBase Выплата => GetProperty<EnumItemBase>("Выплата");
        public EnumItemBase ПереносКопеекНаСледующийМесяц => GetProperty<EnumItemBase>("ПереносКопеекНаСледующийМесяц");
        public EnumItemBase УдалитьВыплатаАванса => GetProperty<EnumItemBase>("УдалитьВыплатаАванса");
        public EnumItemBase УдалитьВыплатаМежрасчетная => GetProperty<EnumItemBase>("УдалитьВыплатаМежрасчетная");
        public EnumItemBase УдалитьВыплатаОчередная => GetProperty<EnumItemBase>("УдалитьВыплатаОчередная");
        public EnumItemBase УдалитьВыплатаДивидендов => GetProperty<EnumItemBase>("УдалитьВыплатаДивидендов");
        public EnumItemBase УдалитьВыплатаДепонента => GetProperty<EnumItemBase>("УдалитьВыплатаДепонента");
        public EnumItemBase УдалитьПогашениеНачисленийПоФактуВыплаты => GetProperty<EnumItemBase>("УдалитьПогашениеНачисленийПоФактуВыплаты");
        public EnumItemBase УдалитьВключениеКопеекПредыдущегоМесяца => GetProperty<EnumItemBase>("УдалитьВключениеКопеекПредыдущегоМесяца");
    }
}
