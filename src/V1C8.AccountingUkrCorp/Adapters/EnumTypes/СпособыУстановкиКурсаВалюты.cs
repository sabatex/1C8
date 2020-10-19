using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыУстановкиКурсаВалюты:V1C8COMObject
    {
        public СпособыУстановкиКурсаВалюты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗагрузкаИзИнтернета => GetProperty<EnumItemBase>("ЗагрузкаИзИнтернета");
        public EnumItemBase РучнойВвод => GetProperty<EnumItemBase>("РучнойВвод");
        public EnumItemBase НаценкаНаКурсДругойВалюты => GetProperty<EnumItemBase>("НаценкаНаКурсДругойВалюты");
        public EnumItemBase РасчетПоФормуле => GetProperty<EnumItemBase>("РасчетПоФормуле");
    }
}
