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
    [Table("TypyKontaktnoiYnformatsyy")]
    [Description1C8(Name = "ТипыКонтактнойИнформации", Comment = "", Synonym = "Типы контактной информации")]
    public class ТипыКонтактнойИнформации:EnumItem
    {
        public static readonly ТипыКонтактнойИнформации Адрес = new ТипыКонтактнойИнформации{Name= "Адрес",Synonym="Адрес",Comment=""};
        public static readonly ТипыКонтактнойИнформации Телефон = new ТипыКонтактнойИнформации{Name= "Телефон",Synonym="Телефон",Comment=""};
        public static readonly ТипыКонтактнойИнформации АдресЭлектроннойПочты = new ТипыКонтактнойИнформации{Name= "АдресЭлектроннойПочты",Synonym="Адрес электронной почты",Comment=""};
        public static readonly ТипыКонтактнойИнформации Skype = new ТипыКонтактнойИнформации{Name= "Skype",Synonym="Skype",Comment=""};
        public static readonly ТипыКонтактнойИнформации ВебСтраница = new ТипыКонтактнойИнформации{Name= "ВебСтраница",Synonym="Веб страница",Comment=""};
        public static readonly ТипыКонтактнойИнформации Факс = new ТипыКонтактнойИнформации{Name= "Факс",Synonym="Факс",Comment=""};
        public static readonly ТипыКонтактнойИнформации Другое = new ТипыКонтактнойИнформации{Name= "Другое",Synonym="Другое",Comment=""};
    }
}
