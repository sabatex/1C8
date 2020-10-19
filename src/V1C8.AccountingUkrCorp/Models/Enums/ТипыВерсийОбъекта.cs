using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("TypyVersyiObekta")]
    [Description1C8(Name = "ТипыВерсийОбъекта", Comment = "", Synonym = "Типы версий объекта")]
    public class ТипыВерсийОбъекта:EnumItem
    {
        public static readonly ТипыВерсийОбъекта ИзмененоПользователем = new ТипыВерсийОбъекта{Name= "ИзмененоПользователем",Synonym="Изменено пользователем",Comment=""};
        public static readonly ТипыВерсийОбъекта ПринятыеДанныеПоКоллизии = new ТипыВерсийОбъекта{Name= "ПринятыеДанныеПоКоллизии",Synonym="Принятые данные по коллизии",Comment=""};
        public static readonly ТипыВерсийОбъекта НепринятыеДанныеПоКоллизии = new ТипыВерсийОбъекта{Name= "НепринятыеДанныеПоКоллизии",Synonym="Непринятые данные по коллизии",Comment=""};
        public static readonly ТипыВерсийОбъекта НепринятыйПоДатеЗапретаОбъектСуществуетВБазе = new ТипыВерсийОбъекта{Name= "НепринятыйПоДатеЗапретаОбъектСуществуетВБазе",Synonym="Непринятый по дате запрета объект существует в базе",Comment=""};
        public static readonly ТипыВерсийОбъекта НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе = new ТипыВерсийОбъекта{Name= "НепринятыйПоДатеЗапретаОбъектНеСуществуетВБазе",Synonym="Непринятый по дате запрета объект не существует в базе",Comment=""};
    }
}
