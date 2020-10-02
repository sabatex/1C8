using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСтажа", Comment = "", Synonym = "Категории стажа")]
    public class КатегорииСтажа:EnumItem
    {
        public static readonly КатегорииСтажа ВыслугаЛет = new КатегорииСтажа{Name= "ВыслугаЛет",Synonym="Выслуга лет",Comment=""};
        public static readonly КатегорииСтажа Медицинский = new КатегорииСтажа{Name= "Медицинский",Synonym="Медицинский",Comment=""};
        public static readonly КатегорииСтажа Непрерывный = new КатегорииСтажа{Name= "Непрерывный",Synonym="Непрерывный",Comment=""};
        public static readonly КатегорииСтажа Общий = new КатегорииСтажа{Name= "Общий",Synonym="Общий",Comment=""};
        public static readonly КатегорииСтажа ОбщийНаучноПедагогический = new КатегорииСтажа{Name= "ОбщийНаучноПедагогический",Synonym="Общий научно-педагогический",Comment=""};
        public static readonly КатегорииСтажа Педагогический = new КатегорииСтажа{Name= "Педагогический",Synonym="Педагогический",Comment=""};
        public static readonly КатегорииСтажа Прочее = new КатегорииСтажа{Name= "Прочее",Synonym="Прочее",Comment=""};
        public static readonly КатегорииСтажа РасширенныйСтраховой = new КатегорииСтажа{Name= "РасширенныйСтраховой",Synonym="Расширенный страховой",Comment=""};
        public static readonly КатегорииСтажа Северный = new КатегорииСтажа{Name= "Северный",Synonym="Северный",Comment=""};
        public static readonly КатегорииСтажа Страховой = new КатегорииСтажа{Name= "Страховой",Synonym="Страховой",Comment=""};
        public static readonly КатегорииСтажа ВыслугаЛетНаГосударственнойСлужбе = new КатегорииСтажа{Name= "ВыслугаЛетНаГосударственнойСлужбе",Synonym="Выслуга лет на государственной (муниципальной) службе",Comment=""};
        public static readonly КатегорииСтажа ВыслугаЛетНаВоеннойСлужбе = new КатегорииСтажа{Name= "ВыслугаЛетНаВоеннойСлужбе",Synonym="Выслуга лет на военной службе",Comment=""};
    }
}
