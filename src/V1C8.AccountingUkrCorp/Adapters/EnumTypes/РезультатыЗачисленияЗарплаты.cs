using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РезультатыЗачисленияЗарплаты:EnumBase
    {
        public РезультатыЗачисленияЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Зачислено => GetProperty<EnumItem>("Зачислено");
        public EnumItem ОшибкаФИО => GetProperty<EnumItem>("ОшибкаФИО");
        public EnumItem СчетЗакрыт => GetProperty<EnumItem>("СчетЗакрыт");
        public EnumItem СчетОтсутствует => GetProperty<EnumItem>("СчетОтсутствует");
        public EnumItem НеЗачислено => GetProperty<EnumItem>("НеЗачислено");
    }
}
