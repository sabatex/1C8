using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийСчетНаОплатуПоставщика:V1C8COMObject
    {
        public ВидыОперацийСчетНаОплатуПоставщика(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПокупкаКомиссия => GetProperty<EnumItemBase>();
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>();
        public EnumItemBase ОбъектыСтроительства => GetProperty<EnumItemBase>();
    }
}
