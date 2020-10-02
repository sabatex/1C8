using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДополнительныеЗначенияДоступа", Comment = "", Synonym = "Дополнительные значения доступа")]
    public class ДополнительныеЗначенияДоступа:EnumItem
    {
        public static readonly ДополнительныеЗначенияДоступа ДоступРазрешен = new ДополнительныеЗначенияДоступа{Name= "ДоступРазрешен",Synonym="Доступ разрешен",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа ДоступЗапрещен = new ДополнительныеЗначенияДоступа{Name= "ДоступЗапрещен",Synonym="Доступ запрещен",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа Истина = new ДополнительныеЗначенияДоступа{Name= "Истина",Synonym="Истина",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа Ложь = new ДополнительныеЗначенияДоступа{Name= "Ложь",Synonym="Ложь",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа ПустаяСсылкаЛюбогоТипа = new ДополнительныеЗначенияДоступа{Name= "ПустаяСсылкаЛюбогоТипа",Synonym="Пустая ссылка любого типа",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа Неопределено = new ДополнительныеЗначенияДоступа{Name= "Неопределено",Synonym="Неопределено",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа Null = new ДополнительныеЗначенияДоступа{Name= "Null",Synonym="Null",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа ТипРазрешенный = new ДополнительныеЗначенияДоступа{Name= "ТипРазрешенный",Synonym="Тип разрешенный",Comment=""};
        public static readonly ДополнительныеЗначенияДоступа ТипЗапрещенный = new ДополнительныеЗначенияДоступа{Name= "ТипЗапрещенный",Synonym="Тип запрещенный",Comment=""};
    }
}
