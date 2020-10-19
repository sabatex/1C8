using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыОтчетов:V1C8COMObject
    {
        public ТипыОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Внутренний => GetProperty<EnumItemBase>("Внутренний");
        public EnumItemBase Дополнительный => GetProperty<EnumItemBase>("Дополнительный");
        public EnumItemBase Расширение => GetProperty<EnumItemBase>("Расширение");
        public EnumItemBase Внешний => GetProperty<EnumItemBase>("Внешний");
        public EnumItemBase УдалитьОтчет => GetProperty<EnumItemBase>("УдалитьОтчет");
        public EnumItemBase УдалитьПользовательский => GetProperty<EnumItemBase>("УдалитьПользовательский");
    }
}
