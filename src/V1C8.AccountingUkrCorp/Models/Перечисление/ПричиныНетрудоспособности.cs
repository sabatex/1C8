using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныНетрудоспособности", Comment = "", Synonym = "Причины нетрудоспособности")]
    public enum ПричиныНетрудоспособности
    {
        [Description1C8(Name = "ОбщееЗаболевание", Comment = "", Synonym = "Заболевание или травма (кроме травм на производстве)")]
        ОбщееЗаболевание,
        [Description1C8(Name = "ПоБеременностиИРодам", Comment = "", Synonym = "Отпуск по беременности и родам")]
        ПоБеременностиИРодам,
        [Description1C8(Name = "ТравмаНаПроизводстве", Comment = "", Synonym = "Травма на производстве")]
        ТравмаНаПроизводстве,
        [Description1C8(Name = "Профзаболевание", Comment = "", Synonym = "Профзаболевание")]
        Профзаболевание,
        [Description1C8(Name = "ПоУходуЗаРебенком", Comment = "", Synonym = "Уход за больным ребенком")]
        ПоУходуЗаРебенком,
        [Description1C8(Name = "ПоУходуЗаВзрослым", Comment = "", Synonym = "Уход за больным взрослым членом семьи")]
        ПоУходуЗаВзрослым,
        [Description1C8(Name = "Карантин", Comment = "", Synonym = "Карантин")]
        Карантин,
        [Description1C8(Name = "Протезирование", Comment = "", Synonym = "Протезирование в стационаре")]
        Протезирование,
        [Description1C8(Name = "ПособиеПриДолечивании", Comment = "", Synonym = "ѳ(не украинский) Долечивание в санаторно-курортных учреждениях")]
        ПособиеПриДолечивании,
        [Description1C8(Name = "ЗаболеваниеЧернобыльцев", Comment = "", Synonym = "Заболевание чернобыльцев")]
        ЗаболеваниеЧернобыльцев,
        [Description1C8(Name = "НепроизводственныеТравмы", Comment = "", Synonym = "Непроизводственные травмы")]
        НепроизводственныеТравмы,
        [Description1C8(Name = "СанаторноКурортноеЛечение", Comment = "", Synonym = "Санаторно-курортное лечение")]
        СанаторноКурортноеЛечение,
        [Description1C8(Name = "COVID_19", Comment = "", Synonym = "Изоляция от COVID-19")]
        COVID_19
    }
}
