using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныНетрудоспособности", Comment = "", Synonym = "Причины нетрудоспособности")]
    public class ПричиныНетрудоспособности:EnumItem
    {
        public static readonly ПричиныНетрудоспособности ОбщееЗаболевание = new ПричиныНетрудоспособности{Name= "ОбщееЗаболевание",Synonim="Заболевание или травма (кроме травм на производстве)",Comment=""};
        public static readonly ПричиныНетрудоспособности ПоБеременностиИРодам = new ПричиныНетрудоспособности{Name= "ПоБеременностиИРодам",Synonim="Отпуск по беременности и родам",Comment=""};
        public static readonly ПричиныНетрудоспособности ТравмаНаПроизводстве = new ПричиныНетрудоспособности{Name= "ТравмаНаПроизводстве",Synonim="Травма на производстве",Comment=""};
        public static readonly ПричиныНетрудоспособности Профзаболевание = new ПричиныНетрудоспособности{Name= "Профзаболевание",Synonim="Профзаболевание",Comment=""};
        public static readonly ПричиныНетрудоспособности ПоУходуЗаРебенком = new ПричиныНетрудоспособности{Name= "ПоУходуЗаРебенком",Synonim="Уход за больным ребенком",Comment=""};
        public static readonly ПричиныНетрудоспособности ПоУходуЗаВзрослым = new ПричиныНетрудоспособности{Name= "ПоУходуЗаВзрослым",Synonim="Уход за больным взрослым членом семьи",Comment=""};
        public static readonly ПричиныНетрудоспособности Карантин = new ПричиныНетрудоспособности{Name= "Карантин",Synonim="Карантин",Comment=""};
        public static readonly ПричиныНетрудоспособности Протезирование = new ПричиныНетрудоспособности{Name= "Протезирование",Synonim="Протезирование в стационаре",Comment=""};
        public static readonly ПричиныНетрудоспособности ПособиеПриДолечивании = new ПричиныНетрудоспособности{Name= "ПособиеПриДолечивании",Synonim="ѳ(не украинский) Долечивание в санаторно-курортных учреждениях",Comment=""};
        public static readonly ПричиныНетрудоспособности ЗаболеваниеЧернобыльцев = new ПричиныНетрудоспособности{Name= "ЗаболеваниеЧернобыльцев",Synonim="Заболевание чернобыльцев",Comment=""};
        public static readonly ПричиныНетрудоспособности НепроизводственныеТравмы = new ПричиныНетрудоспособности{Name= "НепроизводственныеТравмы",Synonim="Непроизводственные травмы",Comment=""};
        public static readonly ПричиныНетрудоспособности СанаторноКурортноеЛечение = new ПричиныНетрудоспособности{Name= "СанаторноКурортноеЛечение",Synonim="Санаторно-курортное лечение",Comment=""};
        public static readonly ПричиныНетрудоспособности COVID_19 = new ПричиныНетрудоспособности{Name= "COVID_19",Synonim="Изоляция от COVID-19",Comment=""};
    }
}
