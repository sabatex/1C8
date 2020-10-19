using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РезультатыЗачисленияЗарплаты:V1C8COMObject
    {
        public РезультатыЗачисленияЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Зачислено => GetProperty<EnumItemBase>("Зачислено");
        public EnumItemBase ОшибкаФИО => GetProperty<EnumItemBase>("ОшибкаФИО");
        public EnumItemBase СчетЗакрыт => GetProperty<EnumItemBase>("СчетЗакрыт");
        public EnumItemBase СчетОтсутствует => GetProperty<EnumItemBase>("СчетОтсутствует");
        public EnumItemBase НеЗачислено => GetProperty<EnumItemBase>("НеЗачислено");
    }
}
