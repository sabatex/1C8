using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ДополнительнаяКолонкаПечатныхФормДокументов:V1C8COMObject
    {
        public ДополнительнаяКолонкаПечатныхФормДокументов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеВыводить => GetProperty<EnumItemBase>();
        public EnumItemBase Артикул => GetProperty<EnumItemBase>();
        public EnumItemBase Код => GetProperty<EnumItemBase>();
    }
}
