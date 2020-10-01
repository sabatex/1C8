using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОстатковНДСПродажПодтвержденный", Comment = "", Synonym = "Виды остатков подтвержденнного НДС по продажам")]
    public enum ВидыОстатковНДСПродажПодтвержденный
    {
        [Description1C8(Name = "НеправильноЗарегистрированы", Comment = "", Synonym = "Неправильно оформленные нал. док-ты (требуется корректировка)")]
        НеправильноЗарегистрированы,
        [Description1C8(Name = "ВыписаныЗаранее", Comment = "", Synonym = "Заранее выписанные нал. док-ты (не требуется корректировка)")]
        ВыписаныЗаранее
    }
}
