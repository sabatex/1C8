using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыВерсийОбъекта", Comment = "", Synonym = "Типы версий объекта")]
    public enum ТипыВерсийОбъекта
    {
        [Description1C8(Name = "ИзмененоПользователем", Comment = "", Synonym = "Изменено пользователем")]
        ИзмененоПользователем,
        [Description1C8(Name = "ПринятыеДанныеПоКоллизии", Comment = "", Synonym = "Принятые данные по коллизии")]
        ПринятыеДанныеПоКоллизии,
        [Description1C8(Name = "НепринятыеДанныеПоКоллизии", Comment = "", Synonym = "Непринятые данные по коллизии")]
        НепринятыеДанныеПоКоллизии,
        [Description1C8(Name = "НепринятыйПоДатеЗапретаОбъектСуществуетВБазе", Comment = "", Synonym = "Непринятый по дате запрета объект существует в базе")]
        НепринятыйПоДатеЗапретаОбъектСуществуетВБазе,
        [Description1C8(Name = "НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе", Comment = "", Synonym = "Непринятый по дате запрета объект не существует в базе")]
        НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе
    }
}
