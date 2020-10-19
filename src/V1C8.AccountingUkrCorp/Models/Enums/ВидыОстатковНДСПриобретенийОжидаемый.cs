using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("VydyOstatkovNDSPryobretenyiOzhydaemyi")]
    [Description1C8(Name = "ВидыОстатковНДСПриобретенийОжидаемый", Comment = "", Synonym = "Виды остатков ожидаемого НДС по приобретениям")]
    public class ВидыОстатковНДСПриобретенийОжидаемый:EnumItem
    {
        public static readonly ВидыОстатковНДСПриобретенийОжидаемый ПравильнаяРегистрация = new ВидыОстатковНДСПриобретенийОжидаемый{Name= "ПравильнаяРегистрация",Synonym="Правильное оформление нал. док-тов (корректируют неправильно оформленные)",Comment=""};
        public static readonly ВидыОстатковНДСПриобретенийОжидаемый ЕщеНеПолучены = new ВидыОстатковНДСПриобретенийОжидаемый{Name= "ЕщеНеПолучены",Synonym="Еще не полученные нал. док-ты (не требуется корректировка)",Comment=""};
        public static readonly ВидыОстатковНДСПриобретенийОжидаемый НеБудутПолучены = new ВидыОстатковНДСПриобретенийОжидаемый{Name= "НеБудутПолучены",Synonym="Нал. док-ты не будут получены (требуется корректировка)",Comment=""};
    }
}
