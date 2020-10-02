using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыВерсийОбъекта", Comment = "", Synonym = "Типы версий объекта")]
    public class ТипыВерсийОбъекта:EnumItem
    {
        public static readonly ТипыВерсийОбъекта ИзмененоПользователем = new ТипыВерсийОбъекта{Name= "ИзмененоПользователем",Synonim="Изменено пользователем",Comment=""};
        public static readonly ТипыВерсийОбъекта ПринятыеДанныеПоКоллизии = new ТипыВерсийОбъекта{Name= "ПринятыеДанныеПоКоллизии",Synonim="Принятые данные по коллизии",Comment=""};
        public static readonly ТипыВерсийОбъекта НепринятыеДанныеПоКоллизии = new ТипыВерсийОбъекта{Name= "НепринятыеДанныеПоКоллизии",Synonim="Непринятые данные по коллизии",Comment=""};
        public static readonly ТипыВерсийОбъекта НепринятыйПоДатеЗапретаОбъектСуществуетВБазе = new ТипыВерсийОбъекта{Name= "НепринятыйПоДатеЗапретаОбъектСуществуетВБазе",Synonim="Непринятый по дате запрета объект существует в базе",Comment=""};
        public static readonly ТипыВерсийОбъекта НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе = new ТипыВерсийОбъекта{Name= "НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе",Synonim="Непринятый по дате запрета объект не существует в базе",Comment=""};
    }
}
