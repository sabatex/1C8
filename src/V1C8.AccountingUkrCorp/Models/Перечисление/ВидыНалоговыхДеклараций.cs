using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНалоговыхДеклараций", Comment = "", Synonym = "Виды налоговых деклараций")]
    public enum ВидыНалоговыхДеклараций
    {
        [Description1C8(Name = "ДекларацияПоНалогуНаПрибыль2015", Comment = "", Synonym = "Декларация по налогу на прибыль")]
        ДекларацияПоНалогуНаПрибыль2015,
        [Description1C8(Name = "ДекларацияПоНДС", Comment = "", Synonym = "Декларация по НДС")]
        ДекларацияПоНДС,
        [Description1C8(Name = "Пенсионный", Comment = "", Synonym = "Отчет в ПФ")]
        Пенсионный,
        [Description1C8(Name = "Безработица", Comment = "", Synonym = "Отчет в ФСС на случай безработицы")]
        Безработица,
        [Description1C8(Name = "НесчастныйСлучай", Comment = "", Synonym = "Отчет в ФСС от несчастных случаев")]
        НесчастныйСлучай,
        [Description1C8(Name = "УтратаТрудоспобности", Comment = "", Synonym = "Отчет в ФСС в связи с утратой трудоспобности")]
        УтратаТрудоспобности,
        [Description1C8(Name = "ЕдиныйНалог", Comment = "", Synonym = "Отчет по Единому налогу")]
        ЕдиныйНалог,
        [Description1C8(Name = "ОтчетПоТруду", Comment = "", Synonym = "Отчет по труду")]
        ОтчетПоТруду,
        [Description1C8(Name = "ОтчетОбИспользованииРабочегоВремени", Comment = "", Synonym = "Отчет об использовании рабочего времени")]
        ОтчетОбИспользованииРабочегоВремени,
        [Description1C8(Name = "ЕСВ", Comment = "", Synonym = "Отчет по ЕСВ")]
        ЕСВ,
        [Description1C8(Name = "ДекларацияОПрибыли", Comment = "", Synonym = "(не используется) Декларация о прибыли (до 01.04.2011)")]
        ДекларацияОПрибыли,
        [Description1C8(Name = "ДекларацияПоНалогуНаПрибыльНКУ", Comment = "", Synonym = "(не используется) Декларация по налогу на прибыль (до 01.01.2015)")]
        ДекларацияПоНалогуНаПрибыльНКУ,
        [Description1C8(Name = "ДекларацияПоАкцизномуНалогу", Comment = "", Synonym = "Декларация по акцизному налогу")]
        ДекларацияПоАкцизномуНалогу
    }
}
