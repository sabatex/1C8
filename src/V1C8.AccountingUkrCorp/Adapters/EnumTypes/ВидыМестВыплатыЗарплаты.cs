using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыМестВыплатыЗарплаты:V1C8COMObject
    {
        public ВидыМестВыплатыЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Касса => GetProperty<EnumItemBase>("Касса");
        public EnumItemBase ЗарплатныйПроект => GetProperty<EnumItemBase>("ЗарплатныйПроект");
        public EnumItemBase Раздатчик => GetProperty<EnumItemBase>("Раздатчик");
        public EnumItemBase БанковскийСчет => GetProperty<EnumItemBase>("БанковскийСчет");
    }
}
