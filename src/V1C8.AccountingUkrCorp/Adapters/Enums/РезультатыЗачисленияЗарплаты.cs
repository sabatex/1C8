using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РезультатыЗачисленияЗарплаты:V1C8COMObject
    {
        public РезультатыЗачисленияЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Зачислено => GetProperty<EnumItemBase>();
        public EnumItemBase ОшибкаФИО => GetProperty<EnumItemBase>();
        public EnumItemBase СчетЗакрыт => GetProperty<EnumItemBase>();
        public EnumItemBase СчетОтсутствует => GetProperty<EnumItemBase>();
        public EnumItemBase НеЗачислено => GetProperty<EnumItemBase>();
    }
}
