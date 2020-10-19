using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыМестВыплатыЗарплаты:EnumBase
    {
        public ВидыМестВыплатыЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Касса => GetProperty<EnumItem>("Касса");
        public EnumItem ЗарплатныйПроект => GetProperty<EnumItem>("ЗарплатныйПроект");
        public EnumItem Раздатчик => GetProperty<EnumItem>("Раздатчик");
        public EnumItem БанковскийСчет => GetProperty<EnumItem>("БанковскийСчет");
    }
}
