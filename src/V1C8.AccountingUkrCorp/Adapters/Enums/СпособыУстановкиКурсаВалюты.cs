using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыУстановкиКурсаВалюты:V1C8COMObject
    {
        public СпособыУстановкиКурсаВалюты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗагрузкаИзИнтернета => GetProperty<EnumItemBase>();
        public EnumItemBase РучнойВвод => GetProperty<EnumItemBase>();
        public EnumItemBase НаценкаНаКурсДругойВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетПоФормуле => GetProperty<EnumItemBase>();
    }
}
