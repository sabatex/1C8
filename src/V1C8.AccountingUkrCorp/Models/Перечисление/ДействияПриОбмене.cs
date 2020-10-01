using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияПриОбмене", Comment = "", Synonym = "Действия при обмене")]
    public enum ДействияПриОбмене
    {
        [Description1C8(Name = "ЗагрузкаДанных", Comment = "", Synonym = "Получение данных")]
        ЗагрузкаДанных,
        [Description1C8(Name = "ВыгрузкаДанных", Comment = "", Synonym = "Отправка данных")]
        ВыгрузкаДанных
    }
}
