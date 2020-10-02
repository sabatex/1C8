using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыОбъектовКонтактнойИнформации", Comment = "(Упр) Виды объектов контактной информации", Synonym = "(не используется) Виды объектов контактной информации")]
    public class УдалитьВидыОбъектовКонтактнойИнформации:EnumItem
    {
        public static readonly УдалитьВидыОбъектовКонтактнойИнформации Контрагенты = new УдалитьВидыОбъектовКонтактнойИнформации{Name= "Контрагенты",Synonim="Справочник 'Контрагенты'",Comment="Справочник контрагентов"};
        public static readonly УдалитьВидыОбъектовКонтактнойИнформации КонтактныеЛица = new УдалитьВидыОбъектовКонтактнойИнформации{Name= "КонтактныеЛица",Synonim="Справочник 'Контактные лица'",Comment=""};
        public static readonly УдалитьВидыОбъектовКонтактнойИнформации ФизическиеЛица = new УдалитьВидыОбъектовКонтактнойИнформации{Name= "ФизическиеЛица",Synonim="Справочник 'Физические лица'",Comment="Справочник 'Физические лица', контактные лица контрагентов, менеджеры"};
        public static readonly УдалитьВидыОбъектовКонтактнойИнформации Организации = new УдалитьВидыОбъектовКонтактнойИнформации{Name= "Организации",Synonim="Справочник 'Организации'",Comment=""};
        public static readonly УдалитьВидыОбъектовКонтактнойИнформации Пользователи = new УдалитьВидыОбъектовКонтактнойИнформации{Name= "Пользователи",Synonim="Справочник 'Пользователи'",Comment=""};
    }
}
