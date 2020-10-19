using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРасчетаСреднегоЗаработкаФСС:V1C8COMObject
    {
        public ПорядокРасчетаСреднегоЗаработкаФСС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Постановление2010 => GetProperty<EnumItemBase>("Постановление2010");
        public EnumItemBase Постановление2011 => GetProperty<EnumItemBase>("Постановление2011");
    }
}
