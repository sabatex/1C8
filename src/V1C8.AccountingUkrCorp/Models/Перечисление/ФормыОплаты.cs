using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФормыОплаты", Comment = "", Synonym = "Формы оплаты")]
    public enum ФормыОплаты
    {
        [Description1C8(Name = "Наличная", Comment = "", Synonym = "Наличная")]
        Наличная,
        [Description1C8(Name = "Безналичная", Comment = "", Synonym = "Безналичная")]
        Безналичная,
        [Description1C8(Name = "ПлатежнаяКарта", Comment = "", Synonym = "Платежная карта")]
        ПлатежнаяКарта,
        [Description1C8(Name = "Взаимозачет", Comment = "", Synonym = "Взаимозачет")]
        Взаимозачет,
        [Description1C8(Name = "БонусныеБаллы", Comment = "", Synonym = "Бонусные баллы")]
        БонусныеБаллы,
        [Description1C8(Name = "ПодарочныйСертификат", Comment = "", Synonym = "Подарочный сертификат")]
        ПодарочныйСертификат
    }
}
