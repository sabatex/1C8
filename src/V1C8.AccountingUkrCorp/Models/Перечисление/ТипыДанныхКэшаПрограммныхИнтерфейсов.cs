using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыДанныхКэшаПрограммныхИнтерфейсов", Comment = "", Synonym = "Типы данных кэша программных интерфейсов")]
    public enum ТипыДанныхКэшаПрограммныхИнтерфейсов
    {
        [Description1C8(Name = "ОписаниеWebСервиса", Comment = "", Synonym = "Описание web-сервиса")]
        ОписаниеWebСервиса,
        [Description1C8(Name = "ВерсииИнтерфейса", Comment = "", Synonym = "Версии интерфейса")]
        ВерсииИнтерфейса
    }
}
