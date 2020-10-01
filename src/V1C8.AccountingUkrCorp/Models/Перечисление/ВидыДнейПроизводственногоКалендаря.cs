using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДнейПроизводственногоКалендаря", Comment = "", Synonym = "Виды дней производственного календаря")]
    public enum ВидыДнейПроизводственногоКалендаря
    {
        [Description1C8(Name = "Рабочий", Comment = "", Synonym = "Рабочий")]
        Рабочий,
        [Description1C8(Name = "Суббота", Comment = "", Synonym = "Суббота")]
        Суббота,
        [Description1C8(Name = "Воскресенье", Comment = "", Synonym = "Воскресенье")]
        Воскресенье,
        [Description1C8(Name = "Предпраздничный", Comment = "", Synonym = "Предпраздничный")]
        Предпраздничный,
        [Description1C8(Name = "Праздник", Comment = "", Synonym = "Праздник")]
        Праздник,
        [Description1C8(Name = "Нерабочий", Comment = "", Synonym = "Нерабочий")]
        Нерабочий
    }
}
