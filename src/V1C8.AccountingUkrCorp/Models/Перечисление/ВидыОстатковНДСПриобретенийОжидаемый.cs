using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОстатковНДСПриобретенийОжидаемый", Comment = "", Synonym = "Виды остатков ожидаемого НДС по приобретениям")]
    public enum ВидыОстатковНДСПриобретенийОжидаемый
    {
        [Description1C8(Name = "ПравильнаяРегистрация", Comment = "", Synonym = "Правильное оформление нал. док-тов (корректируют неправильно оформленные)")]
        ПравильнаяРегистрация,
        [Description1C8(Name = "ЕщеНеПолучены", Comment = "", Synonym = "Еще не полученные нал. док-ты (не требуется корректировка)")]
        ЕщеНеПолучены,
        [Description1C8(Name = "НеБудутПолучены", Comment = "", Synonym = "Нал. док-ты не будут получены (требуется корректировка)")]
        НеБудутПолучены
    }
}
