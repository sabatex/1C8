using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядокРасчетаСреднегоЗаработкаФСС:V1C8COMObject
    {
        public ПорядокРасчетаСреднегоЗаработкаФСС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Постановление2010 => GetProperty<EnumItemBase>();
        public EnumItemBase Постановление2011 => GetProperty<EnumItemBase>();
    }
}
