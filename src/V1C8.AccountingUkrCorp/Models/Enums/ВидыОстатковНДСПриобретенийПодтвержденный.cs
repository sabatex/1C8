using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОстатковНДСПриобретенийПодтвержденный", Comment = "", Synonym = "Виды остатков подтвержденнного НДС по приобретениям")]
    public class ВидыОстатковНДСПриобретенийПодтвержденный:EnumItem
    {
        public static readonly ВидыОстатковНДСПриобретенийПодтвержденный НеправильноЗарегистрированы = new ВидыОстатковНДСПриобретенийПодтвержденный{Name= "НеправильноЗарегистрированы",Synonym="Неправильно оформленные нал. док-ты (требуется корректировка)",Comment=""};
        public static readonly ВидыОстатковНДСПриобретенийПодтвержденный ПолученыИзлишне = new ВидыОстатковНДСПриобретенийПодтвержденный{Name= "ПолученыИзлишне",Synonym="Излишне полученные нал. док-ты (требуется корректировка)",Comment=""};
        public static readonly ВидыОстатковНДСПриобретенийПодтвержденный ПолученыЗаранее = new ВидыОстатковНДСПриобретенийПодтвержденный{Name= "ПолученыЗаранее",Synonym="Полученные заранее нал. док-ты (не требуется корректировка)",Comment=""};
    }
}
