using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыЕСВ:V1C8COMObject
    {
        public ВидыЕСВ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновнаяЗарплата => GetProperty<EnumItemBase>("ОсновнаяЗарплата");
        public EnumItemBase ПоДоговорамГПХ => GetProperty<EnumItemBase>("ПоДоговорамГПХ");
        public EnumItemBase Больничные => GetProperty<EnumItemBase>("Больничные");
        public EnumItemBase Декретные => GetProperty<EnumItemBase>("Декретные");
        public EnumItemBase НачисленияМобилизованным => GetProperty<EnumItemBase>("НачисленияМобилизованным");
        public EnumItemBase НеУчитывается => GetProperty<EnumItemBase>("НеУчитывается");
    }
}
