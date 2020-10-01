using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыОбъектовКонтактнойИнформации", Comment = "(Упр) Виды объектов контактной информации", Synonym = "(не используется) Виды объектов контактной информации")]
    public enum УдалитьВидыОбъектовКонтактнойИнформации
    {
        [Description1C8(Name = "Контрагенты", Comment = "Справочник контрагентов", Synonym = "Справочник 'Контрагенты'")]
        Контрагенты,
        [Description1C8(Name = "КонтактныеЛица", Comment = "", Synonym = "Справочник 'Контактные лица'")]
        КонтактныеЛица,
        [Description1C8(Name = "ФизическиеЛица", Comment = "Справочник 'Физические лица', контактные лица контрагентов, менеджеры", Synonym = "Справочник 'Физические лица'")]
        ФизическиеЛица,
        [Description1C8(Name = "Организации", Comment = "", Synonym = "Справочник 'Организации'")]
        Организации,
        [Description1C8(Name = "Пользователи", Comment = "", Synonym = "Справочник 'Пользователи'")]
        Пользователи
    }
}
