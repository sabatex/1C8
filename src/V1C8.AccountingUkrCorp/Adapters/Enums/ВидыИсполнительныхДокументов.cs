using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыИсполнительныхДокументов:V1C8COMObject
    {
        public ВидыИсполнительныхДокументов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ИсполнительныйЛист => GetProperty<EnumItemBase>();
        public EnumItemBase СоглашениеОбУплатеАлиментов => GetProperty<EnumItemBase>();
    }
}
