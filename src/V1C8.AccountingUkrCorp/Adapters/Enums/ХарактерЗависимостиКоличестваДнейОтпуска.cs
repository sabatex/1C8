using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ХарактерЗависимостиКоличестваДнейОтпуска:V1C8COMObject
    {
        public ХарактерЗависимостиКоличестваДнейОтпуска(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеЗависит => GetProperty<EnumItemBase>();
        public EnumItemBase ЗависитОтРабочегоМеста => GetProperty<EnumItemBase>();
        public EnumItemBase ЗависитОтСтажа => GetProperty<EnumItemBase>();
    }
}
