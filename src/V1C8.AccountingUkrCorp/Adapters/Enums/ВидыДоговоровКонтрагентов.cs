using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДоговоровКонтрагентов:V1C8COMObject
    {
        public ВидыДоговоровКонтрагентов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СПоставщиком => GetProperty<EnumItemBase>();
        public EnumItemBase СПокупателем => GetProperty<EnumItemBase>();
        public EnumItemBase СКомитентом => GetProperty<EnumItemBase>();
        public EnumItemBase СКомиссионером => GetProperty<EnumItemBase>();
        public EnumItemBase Бартерный => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
    }
}
