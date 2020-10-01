using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьДействиеПриОбмене", Comment = "", Synonym = "(не используется) Действие при обмене")]
    public enum УдалитьДействиеПриОбмене
    {
        [Description1C8(Name = "ЗагрузкаДанных", Comment = "", Synonym = "Загрузка данных")]
        ЗагрузкаДанных,
        [Description1C8(Name = "ОтложенныеДвижения", Comment = "", Synonym = "Отложенные движения")]
        ОтложенныеДвижения,
        [Description1C8(Name = "ВыгрузкаДанных", Comment = "", Synonym = "Выгрузка данных")]
        ВыгрузкаДанных
    }
}
