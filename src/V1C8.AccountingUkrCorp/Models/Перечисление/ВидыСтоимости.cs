using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСтоимости", Comment = "", Synonym = "Виды стоимости выпуска")]
    public enum ВидыСтоимости
    {
        [Description1C8(Name = "Фактическая", Comment = "Выпуск по фактической стоимости", Synonym = "Выпуск по фактической стоимости")]
        Фактическая,
        [Description1C8(Name = "Плановая", Comment = "Выпуск по плановой стоимости", Synonym = "Выпуск по плановой стоимости")]
        Плановая,
        [Description1C8(Name = "Отклонение", Comment = "Отклонение фактической стоимости выпуска от плановой", Synonym = "Отклонение")]
        Отклонение
    }
}
