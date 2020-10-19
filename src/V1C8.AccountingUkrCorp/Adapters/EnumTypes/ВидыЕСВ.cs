using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыЕСВ:EnumBase
    {
        public ВидыЕСВ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОсновнаяЗарплата => GetProperty<EnumItem>("ОсновнаяЗарплата");
        public EnumItem ПоДоговорамГПХ => GetProperty<EnumItem>("ПоДоговорамГПХ");
        public EnumItem Больничные => GetProperty<EnumItem>("Больничные");
        public EnumItem Декретные => GetProperty<EnumItem>("Декретные");
        public EnumItem НачисленияМобилизованным => GetProperty<EnumItem>("НачисленияМобилизованным");
        public EnumItem НеУчитывается => GetProperty<EnumItem>("НеУчитывается");
    }
}
