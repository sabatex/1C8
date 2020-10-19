using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыВерсийОбъекта:V1C8COMObject
    {
        public ТипыВерсийОбъекта(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ИзмененоПользователем => GetProperty<EnumItemBase>();
        public EnumItemBase ПринятыеДанныеПоКоллизии => GetProperty<EnumItemBase>();
        public EnumItemBase НепринятыеДанныеПоКоллизии => GetProperty<EnumItemBase>();
        public EnumItemBase НепринятыйПоДатеЗапретаОбъектСуществуетВБазе => GetProperty<EnumItemBase>();
        public EnumItemBase НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе => GetProperty<EnumItemBase>();
    }
}
