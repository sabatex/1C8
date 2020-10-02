using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныНетрудоспособности", Comment = "", Synonym = "Причины нетрудоспособности")]
    public class ПричиныНетрудоспособности:EnumItem
    {
        public static readonly ПричиныНетрудоспособности ОбщееЗаболевание = new ПричиныНетрудоспособности{Name= "ОбщееЗаболевание",Synonym="Заболевание или травма (кроме травм на производстве)",Comment=""};
        public static readonly ПричиныНетрудоспособности ПоБеременностиИРодам = new ПричиныНетрудоспособности{Name= "ПоБеременностиИРодам",Synonym="Отпуск по беременности и родам",Comment=""};
        public static readonly ПричиныНетрудоспособности ТравмаНаПроизводстве = new ПричиныНетрудоспособности{Name= "ТравмаНаПроизводстве",Synonym="Травма на производстве",Comment=""};
        public static readonly ПричиныНетрудоспособности Профзаболевание = new ПричиныНетрудоспособности{Name= "Профзаболевание",Synonym="Профзаболевание",Comment=""};
        public static readonly ПричиныНетрудоспособности ПоУходуЗаРебенком = new ПричиныНетрудоспособности{Name= "ПоУходуЗаРебенком",Synonym="Уход за больным ребенком",Comment=""};
        public static readonly ПричиныНетрудоспособности ПоУходуЗаВзрослым = new ПричиныНетрудоспособности{Name= "ПоУходуЗаВзрослым",Synonym="Уход за больным взрослым членом семьи",Comment=""};
        public static readonly ПричиныНетрудоспособности Карантин = new ПричиныНетрудоспособности{Name= "Карантин",Synonym="Карантин",Comment=""};
        public static readonly ПричиныНетрудоспособности Протезирование = new ПричиныНетрудоспособности{Name= "Протезирование",Synonym="Протезирование в стационаре",Comment=""};
        public static readonly ПричиныНетрудоспособности ПособиеПриДолечивании = new ПричиныНетрудоспособности{Name= "ПособиеПриДолечивании",Synonym="ѳ(не украинский) Долечивание в санаторно-курортных учреждениях",Comment=""};
        public static readonly ПричиныНетрудоспособности ЗаболеваниеЧернобыльцев = new ПричиныНетрудоспособности{Name= "ЗаболеваниеЧернобыльцев",Synonym="Заболевание чернобыльцев",Comment=""};
        public static readonly ПричиныНетрудоспособности НепроизводственныеТравмы = new ПричиныНетрудоспособности{Name= "НепроизводственныеТравмы",Synonym="Непроизводственные травмы",Comment=""};
        public static readonly ПричиныНетрудоспособности СанаторноКурортноеЛечение = new ПричиныНетрудоспособности{Name= "СанаторноКурортноеЛечение",Synonym="Санаторно-курортное лечение",Comment=""};
        public static readonly ПричиныНетрудоспособности COVID_19 = new ПричиныНетрудоспособности{Name= "COVID_19",Synonym="Изоляция от COVID-19",Comment=""};
    }
}
