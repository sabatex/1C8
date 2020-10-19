using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДополнительнаяКолонкаПечатныхФормДокументов:EnumBase
    {
        public ДополнительнаяКолонкаПечатныхФормДокументов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеВыводить => GetProperty<EnumItem>("НеВыводить");
        public EnumItem Артикул => GetProperty<EnumItem>("Артикул");
        public EnumItem Код => GetProperty<EnumItem>("Код");
    }
}
