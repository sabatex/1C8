using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРасчетаСреднегоЗаработкаОбщий:V1C8COMObject
    {
        public ПорядокРасчетаСреднегоЗаработкаОбщий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Постановление2010 => GetProperty<EnumItemBase>("Постановление2010");
        public EnumItemBase Постановление100Отпускные => GetProperty<EnumItemBase>("Постановление100Отпускные");
    }
}
