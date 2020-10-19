using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыВерсийОбъекта:EnumBase
    {
        public ТипыВерсийОбъекта(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ИзмененоПользователем => GetProperty<EnumItem>("ИзмененоПользователем");
        public EnumItem ПринятыеДанныеПоКоллизии => GetProperty<EnumItem>("ПринятыеДанныеПоКоллизии");
        public EnumItem НепринятыеДанныеПоКоллизии => GetProperty<EnumItem>("НепринятыеДанныеПоКоллизии");
        public EnumItem НепринятыйПоДатеЗапретаОбъектСуществуетВБазе => GetProperty<EnumItem>("НепринятыйПоДатеЗапретаОбъектСуществуетВБазе");
        public EnumItem НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе => GetProperty<EnumItem>("НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе");
    }
}
