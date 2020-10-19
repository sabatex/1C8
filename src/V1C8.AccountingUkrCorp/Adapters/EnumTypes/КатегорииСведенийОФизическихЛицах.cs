using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСведенийОФизическихЛицах:V1C8COMObject
    {
        public КатегорииСведенийОФизическихЛицах(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Должность => GetProperty<EnumItemBase>("Должность");
        public EnumItemBase Инвалидность => GetProperty<EnumItemBase>("Инвалидность");
        public EnumItemBase КонтактнаяИнформация => GetProperty<EnumItemBase>("КонтактнаяИнформация");
        public EnumItemBase Образование => GetProperty<EnumItemBase>("Образование");
        public EnumItemBase Организация => GetProperty<EnumItemBase>("Организация");
        public EnumItemBase Подразделение => GetProperty<EnumItemBase>("Подразделение");
        public EnumItemBase СемейноеПоложение => GetProperty<EnumItemBase>("СемейноеПоложение");
        public EnumItemBase СоставСемьи => GetProperty<EnumItemBase>("СоставСемьи");
    }
}
