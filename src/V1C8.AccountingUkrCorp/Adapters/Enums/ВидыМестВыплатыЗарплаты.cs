using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыМестВыплатыЗарплаты:V1C8COMObject
    {
        public ВидыМестВыплатыЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Касса => GetProperty<EnumItemBase>();
        public EnumItemBase ЗарплатныйПроект => GetProperty<EnumItemBase>();
        public EnumItemBase Раздатчик => GetProperty<EnumItemBase>();
        public EnumItemBase БанковскийСчет => GetProperty<EnumItemBase>();
    }
}
