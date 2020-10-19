using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыВерсийОбъекта:V1C8COMObject
    {
        public ТипыВерсийОбъекта(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ИзмененоПользователем => GetProperty<EnumItemBase>("ИзмененоПользователем");
        public EnumItemBase ПринятыеДанныеПоКоллизии => GetProperty<EnumItemBase>("ПринятыеДанныеПоКоллизии");
        public EnumItemBase НепринятыеДанныеПоКоллизии => GetProperty<EnumItemBase>("НепринятыеДанныеПоКоллизии");
        public EnumItemBase НепринятыйПоДатеЗапретаОбъектСуществуетВБазе => GetProperty<EnumItemBase>("НепринятыйПоДатеЗапретаОбъектСуществуетВБазе");
        public EnumItemBase НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе => GetProperty<EnumItemBase>("НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе");
    }
}
