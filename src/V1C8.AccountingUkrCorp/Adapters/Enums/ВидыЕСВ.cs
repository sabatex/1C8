using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыЕСВ:V1C8COMObject
    {
        public ВидыЕСВ(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновнаяЗарплата => GetProperty<EnumItemBase>();
        public EnumItemBase ПоДоговорамГПХ => GetProperty<EnumItemBase>();
        public EnumItemBase Больничные => GetProperty<EnumItemBase>();
        public EnumItemBase Декретные => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленияМобилизованным => GetProperty<EnumItemBase>();
        public EnumItemBase НеУчитывается => GetProperty<EnumItemBase>();
    }
}
