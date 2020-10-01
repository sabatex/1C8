using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииУдержаний", Comment = "", Synonym = "Категории удержаний")]
    public enum КатегорииУдержаний
    {
        [Description1C8(Name = "ПрофсоюзныеВзносы", Comment = "", Synonym = "Профсоюзные взносы")]
        ПрофсоюзныеВзносы,
        [Description1C8(Name = "Алименты", Comment = "", Synonym = "Алименты")]
        Алименты,
        [Description1C8(Name = "ИсполнительныйЛист", Comment = "", Synonym = "Исполнительный лист")]
        ИсполнительныйЛист,
        [Description1C8(Name = "ПочтовыйСбор", Comment = "", Synonym = "Почтовый сбор")]
        ПочтовыйСбор,
        [Description1C8(Name = "Прочее", Comment = "", Synonym = "Прочее")]
        Прочее,
        [Description1C8(Name = "ВознаграждениеПлатежногоАгента", Comment = "", Synonym = "Вознаграждение платежного агента")]
        ВознаграждениеПлатежногоАгента,
        [Description1C8(Name = "УдержаниеЗаНеотработанныеДниОтпуска", Comment = "", Synonym = "Удержание за неотработанные дни отпуска")]
        УдержаниеЗаНеотработанныеДниОтпуска,
        [Description1C8(Name = "ДСВ", Comment = "", Synonym = "ѳ(не украинский) Дополнительные страховые взносы на накопительную часть пенсии")]
        ДСВ,
        [Description1C8(Name = "ДобровольныеВзносыВНПФ", Comment = "", Synonym = "ѳ(не украинский) Добровольные взносы в НПФ")]
        ДобровольныеВзносыВНПФ,
        [Description1C8(Name = "ПрочееУдержаниеВПользуТретьихЛиц", Comment = "", Synonym = "Прочее удержание в пользу третьих лиц")]
        ПрочееУдержаниеВПользуТретьихЛиц,
        [Description1C8(Name = "УдержаниеВСчетРасчетовПоПрочимОперациям", Comment = "", Synonym = "Удержание в счет расчетов по прочим операциям")]
        УдержаниеВСчетРасчетовПоПрочимОперациям,
        [Description1C8(Name = "ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска", Comment = "", Synonym = "Удержание за неотработанные дни отпуска (сохраняемое денежное содержание)")]
        ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска,
        [Description1C8(Name = "ОбязательстваПоУченическомуДоговору", Comment = "", Synonym = "ѳ(не украинский) Обязательства по ученическому договору")]
        ОбязательстваПоУченическомуДоговору
    }
}
