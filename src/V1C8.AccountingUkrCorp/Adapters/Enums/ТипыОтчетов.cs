using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыОтчетов:V1C8COMObject
    {
        public ТипыОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Внутренний => GetProperty<EnumItemBase>();
        public EnumItemBase Дополнительный => GetProperty<EnumItemBase>();
        public EnumItemBase Расширение => GetProperty<EnumItemBase>();
        public EnumItemBase Внешний => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьОтчет => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьПользовательский => GetProperty<EnumItemBase>();
    }
}
