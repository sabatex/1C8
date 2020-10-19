using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРасчетаСреднегоЗаработкаФСС:EnumBase
    {
        public ПорядокРасчетаСреднегоЗаработкаФСС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Постановление2010 => GetProperty<EnumItem>("Постановление2010");
        public EnumItem Постановление2011 => GetProperty<EnumItem>("Постановление2011");
    }
}
