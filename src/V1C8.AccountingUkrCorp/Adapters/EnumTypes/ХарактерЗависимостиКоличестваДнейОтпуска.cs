using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ХарактерЗависимостиКоличестваДнейОтпуска:V1C8COMObject
    {
        public ХарактерЗависимостиКоличестваДнейОтпуска(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеЗависит => GetProperty<EnumItemBase>("НеЗависит");
        public EnumItemBase ЗависитОтРабочегоМеста => GetProperty<EnumItemBase>("ЗависитОтРабочегоМеста");
        public EnumItemBase ЗависитОтСтажа => GetProperty<EnumItemBase>("ЗависитОтСтажа");
    }
}
