using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСведенийОФизическихЛицах:EnumBase
    {
        public КатегорииСведенийОФизическихЛицах(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Должность => GetProperty<EnumItem>("Должность");
        public EnumItem Инвалидность => GetProperty<EnumItem>("Инвалидность");
        public EnumItem КонтактнаяИнформация => GetProperty<EnumItem>("КонтактнаяИнформация");
        public EnumItem Образование => GetProperty<EnumItem>("Образование");
        public EnumItem Организация => GetProperty<EnumItem>("Организация");
        public EnumItem Подразделение => GetProperty<EnumItem>("Подразделение");
        public EnumItem СемейноеПоложение => GetProperty<EnumItem>("СемейноеПоложение");
        public EnumItem СоставСемьи => GetProperty<EnumItem>("СоставСемьи");
    }
}
