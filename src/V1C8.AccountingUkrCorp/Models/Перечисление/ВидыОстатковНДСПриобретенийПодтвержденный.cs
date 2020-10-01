using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОстатковНДСПриобретенийПодтвержденный", Comment = "", Synonym = "Виды остатков подтвержденнного НДС по приобретениям")]
    public enum ВидыОстатковНДСПриобретенийПодтвержденный
    {
        [Description1C8(Name = "НеправильноЗарегистрированы", Comment = "", Synonym = "Неправильно оформленные нал. док-ты (требуется корректировка)")]
        НеправильноЗарегистрированы,
        [Description1C8(Name = "ПолученыИзлишне", Comment = "", Synonym = "Излишне полученные нал. док-ты (требуется корректировка)")]
        ПолученыИзлишне,
        [Description1C8(Name = "ПолученыЗаранее", Comment = "", Synonym = "Полученные заранее нал. док-ты (не требуется корректировка)")]
        ПолученыЗаранее
    }
}
