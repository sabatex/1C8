using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииСведенийОФизическихЛицах:V1C8COMObject
    {
        public КатегорииСведенийОФизическихЛицах(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Должность => GetProperty<EnumItemBase>();
        public EnumItemBase Инвалидность => GetProperty<EnumItemBase>();
        public EnumItemBase КонтактнаяИнформация => GetProperty<EnumItemBase>();
        public EnumItemBase Образование => GetProperty<EnumItemBase>();
        public EnumItemBase Организация => GetProperty<EnumItemBase>();
        public EnumItemBase Подразделение => GetProperty<EnumItemBase>();
        public EnumItemBase СемейноеПоложение => GetProperty<EnumItemBase>();
        public EnumItemBase СоставСемьи => GetProperty<EnumItemBase>();
    }
}
