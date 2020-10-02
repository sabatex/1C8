using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНалоговыхДеклараций", Comment = "", Synonym = "Виды налоговых деклараций")]
    public class ВидыНалоговыхДеклараций:EnumItem
    {
        public static readonly ВидыНалоговыхДеклараций ДекларацияПоНалогуНаПрибыль2015 = new ВидыНалоговыхДеклараций{Name= "ДекларацияПоНалогуНаПрибыль2015",Synonym="Декларация по налогу на прибыль",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ДекларацияПоНДС = new ВидыНалоговыхДеклараций{Name= "ДекларацияПоНДС",Synonym="Декларация по НДС",Comment=""};
        public static readonly ВидыНалоговыхДеклараций Пенсионный = new ВидыНалоговыхДеклараций{Name= "Пенсионный",Synonym="Отчет в ПФ",Comment=""};
        public static readonly ВидыНалоговыхДеклараций Безработица = new ВидыНалоговыхДеклараций{Name= "Безработица",Synonym="Отчет в ФСС на случай безработицы",Comment=""};
        public static readonly ВидыНалоговыхДеклараций НесчастныйСлучай = new ВидыНалоговыхДеклараций{Name= "НесчастныйСлучай",Synonym="Отчет в ФСС от несчастных случаев",Comment=""};
        public static readonly ВидыНалоговыхДеклараций УтратаТрудоспобности = new ВидыНалоговыхДеклараций{Name= "УтратаТрудоспобности",Synonym="Отчет в ФСС в связи с утратой трудоспобности",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ЕдиныйНалог = new ВидыНалоговыхДеклараций{Name= "ЕдиныйНалог",Synonym="Отчет по Единому налогу",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ОтчетПоТруду = new ВидыНалоговыхДеклараций{Name= "ОтчетПоТруду",Synonym="Отчет по труду",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ОтчетОбИспользованииРабочегоВремени = new ВидыНалоговыхДеклараций{Name= "ОтчетОбИспользованииРабочегоВремени",Synonym="Отчет об использовании рабочего времени",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ЕСВ = new ВидыНалоговыхДеклараций{Name= "ЕСВ",Synonym="Отчет по ЕСВ",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ДекларацияОПрибыли = new ВидыНалоговыхДеклараций{Name= "ДекларацияОПрибыли",Synonym="(не используется) Декларация о прибыли (до 01.04.2011)",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ДекларацияПоНалогуНаПрибыльНКУ = new ВидыНалоговыхДеклараций{Name= "ДекларацияПоНалогуНаПрибыльНКУ",Synonym="(не используется) Декларация по налогу на прибыль (до 01.01.2015)",Comment=""};
        public static readonly ВидыНалоговыхДеклараций ДекларацияПоАкцизномуНалогу = new ВидыНалоговыхДеклараций{Name= "ДекларацияПоАкцизномуНалогу",Synonym="Декларация по акцизному налогу",Comment=""};
    }
}
