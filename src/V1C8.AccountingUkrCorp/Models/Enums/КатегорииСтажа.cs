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
        public static readonly КатегорииСтажа ВыслугаЛет = new КатегорииСтажа{Name= "ВыслугаЛет",Synonim="Выслуга лет",Comment=""};
        public static readonly КатегорииСтажа Медицинский = new КатегорииСтажа{Name= "Медицинский",Synonim="Медицинский",Comment=""};
        public static readonly КатегорииСтажа Непрерывный = new КатегорииСтажа{Name= "Непрерывный",Synonim="Непрерывный",Comment=""};
        public static readonly КатегорииСтажа Общий = new КатегорииСтажа{Name= "Общий",Synonim="Общий",Comment=""};
        public static readonly КатегорииСтажа ОбщийНаучноПедагогический = new КатегорииСтажа{Name= "ОбщийНаучноПедагогический",Synonim="Общий научно-педагогический",Comment=""};
        public static readonly КатегорииСтажа Педагогический = new КатегорииСтажа{Name= "Педагогический",Synonim="Педагогический",Comment=""};
        public static readonly КатегорииСтажа Прочее = new КатегорииСтажа{Name= "Прочее",Synonim="Прочее",Comment=""};
        public static readonly КатегорииСтажа РасширенныйСтраховой = new КатегорииСтажа{Name= "РасширенныйСтраховой",Synonim="Расширенный страховой",Comment=""};
        public static readonly КатегорииСтажа Северный = new КатегорииСтажа{Name= "Северный",Synonim="Северный",Comment=""};
        public static readonly КатегорииСтажа Страховой = new КатегорииСтажа{Name= "Страховой",Synonim="Страховой",Comment=""};
        public static readonly КатегорииСтажа ВыслугаЛетНаГосударственнойСлужбе = new КатегорииСтажа{Name= "ВыслугаЛетНаГосударственнойСлужбе",Synonim="Выслуга лет на государственной (муниципальной) службе",Comment=""};
        public static readonly КатегорииСтажа ВыслугаЛетНаВоеннойСлужбе = new КатегорииСтажа{Name= "ВыслугаЛетНаВоеннойСлужбе",Synonim="Выслуга лет на военной службе",Comment=""};
    }
}
