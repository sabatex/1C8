using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыКонтактнойИнформации", Comment = "", Synonym = "Типы контактной информации")]
    public class ТипыКонтактнойИнформации:EnumItem
    {
        public static readonly ТипыКонтактнойИнформации Адрес = new ТипыКонтактнойИнформации{Name= "Адрес",Synonim="Адрес",Comment=""};
        public static readonly ТипыКонтактнойИнформации Телефон = new ТипыКонтактнойИнформации{Name= "Телефон",Synonim="Телефон",Comment=""};
        public static readonly ТипыКонтактнойИнформации АдресЭлектроннойПочты = new ТипыКонтактнойИнформации{Name= "АдресЭлектроннойПочты",Synonim="Адрес электронной почты",Comment=""};
        public static readonly ТипыКонтактнойИнформации Skype = new ТипыКонтактнойИнформации{Name= "Skype",Synonim="Skype",Comment=""};
        public static readonly ТипыКонтактнойИнформации ВебСтраница = new ТипыКонтактнойИнформации{Name= "ВебСтраница",Synonim="Веб страница",Comment=""};
        public static readonly ТипыКонтактнойИнформации Факс = new ТипыКонтактнойИнформации{Name= "Факс",Synonim="Факс",Comment=""};
        public static readonly ТипыКонтактнойИнформации Другое = new ТипыКонтактнойИнформации{Name= "Другое",Synonim="Другое",Comment=""};
    }
}
