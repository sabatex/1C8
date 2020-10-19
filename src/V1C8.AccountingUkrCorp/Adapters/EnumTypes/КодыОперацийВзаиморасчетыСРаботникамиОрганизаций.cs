using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодыОперацийВзаиморасчетыСРаботникамиОрганизаций:EnumBase
    {
        public КодыОперацийВзаиморасчетыСРаботникамиОрганизаций(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Начисления => GetProperty<EnumItem>("Начисления");
        public EnumItem Взносы => GetProperty<EnumItem>("Взносы");
        public EnumItem НДФЛ => GetProperty<EnumItem>("НДФЛ");
        public EnumItem Удержания => GetProperty<EnumItem>("Удержания");
        public EnumItem Выплата => GetProperty<EnumItem>("Выплата");
        public EnumItem ПереносКопеекНаСледующийМесяц => GetProperty<EnumItem>("ПереносКопеекНаСледующийМесяц");
        public EnumItem УдалитьВыплатаАванса => GetProperty<EnumItem>("УдалитьВыплатаАванса");
        public EnumItem УдалитьВыплатаМежрасчетная => GetProperty<EnumItem>("УдалитьВыплатаМежрасчетная");
        public EnumItem УдалитьВыплатаОчередная => GetProperty<EnumItem>("УдалитьВыплатаОчередная");
        public EnumItem УдалитьВыплатаДивидендов => GetProperty<EnumItem>("УдалитьВыплатаДивидендов");
        public EnumItem УдалитьВыплатаДепонента => GetProperty<EnumItem>("УдалитьВыплатаДепонента");
        public EnumItem УдалитьПогашениеНачисленийПоФактуВыплаты => GetProperty<EnumItem>("УдалитьПогашениеНачисленийПоФактуВыплаты");
        public EnumItem УдалитьВключениеКопеекПредыдущегоМесяца => GetProperty<EnumItem>("УдалитьВключениеКопеекПредыдущегоМесяца");
    }
}
