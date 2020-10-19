using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыУстановкиКурсаВалюты:EnumBase
    {
        public СпособыУстановкиКурсаВалюты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЗагрузкаИзИнтернета => GetProperty<EnumItem>("ЗагрузкаИзИнтернета");
        public EnumItem РучнойВвод => GetProperty<EnumItem>("РучнойВвод");
        public EnumItem НаценкаНаКурсДругойВалюты => GetProperty<EnumItem>("НаценкаНаКурсДругойВалюты");
        public EnumItem РасчетПоФормуле => GetProperty<EnumItem>("РасчетПоФормуле");
    }
}
