using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыЗаявленийИРеестровНаВыплатуПособий", Comment = "", Synonym = "Статусы заявлений и реестров на выплату пособий")]
    public enum СтатусыЗаявленийИРеестровНаВыплатуПособий
    {
        [Description1C8(Name = "ВРаботе", Comment = "", Synonym = "В работе")]
        ВРаботе,
        [Description1C8(Name = "Подготовлен", Comment = "", Synonym = "Подготовлен")]
        Подготовлен,
        [Description1C8(Name = "ПереданВФСС", Comment = "", Synonym = "Передан в ФСС")]
        ПереданВФСС,
        [Description1C8(Name = "ПринятФСС", Comment = "", Synonym = "ѳ(не украинский) Принят ФСС")]
        ПринятФСС,
        [Description1C8(Name = "НеПринятФСС", Comment = "", Synonym = "ѳ(не украинский) Не принят ФСС")]
        НеПринятФСС,
        [Description1C8(Name = "Аннулирован", Comment = "", Synonym = "ѳ(не украинский) Аннулирован")]
        Аннулирован
    }
}
