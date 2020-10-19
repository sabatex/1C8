using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядокРасчетаСреднегоЗаработкаОбщий:V1C8COMObject
    {
        public ПорядокРасчетаСреднегоЗаработкаОбщий(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Постановление2010 => GetProperty<EnumItemBase>();
        public EnumItemBase Постановление100Отпускные => GetProperty<EnumItemBase>();
    }
}
