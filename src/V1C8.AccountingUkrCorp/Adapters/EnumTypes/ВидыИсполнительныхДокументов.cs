using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыИсполнительныхДокументов:EnumBase
    {
        public ВидыИсполнительныхДокументов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ИсполнительныйЛист => GetProperty<EnumItem>("ИсполнительныйЛист");
        public EnumItem СоглашениеОбУплатеАлиментов => GetProperty<EnumItem>("СоглашениеОбУплатеАлиментов");
    }
}
