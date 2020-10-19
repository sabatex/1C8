using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ХарактерЗависимостиКоличестваДнейОтпуска:EnumBase
    {
        public ХарактерЗависимостиКоличестваДнейОтпуска(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеЗависит => GetProperty<EnumItem>("НеЗависит");
        public EnumItem ЗависитОтРабочегоМеста => GetProperty<EnumItem>("ЗависитОтРабочегоМеста");
        public EnumItem ЗависитОтСтажа => GetProperty<EnumItem>("ЗависитОтСтажа");
    }
}
