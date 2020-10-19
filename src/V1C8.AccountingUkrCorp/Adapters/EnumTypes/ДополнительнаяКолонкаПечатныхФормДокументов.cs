using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДополнительнаяКолонкаПечатныхФормДокументов:V1C8COMObject
    {
        public ДополнительнаяКолонкаПечатныхФормДокументов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеВыводить => GetProperty<EnumItemBase>("НеВыводить");
        public EnumItemBase Артикул => GetProperty<EnumItemBase>("Артикул");
        public EnumItemBase Код => GetProperty<EnumItemBase>("Код");
    }
}
