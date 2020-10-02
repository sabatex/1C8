using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОстатковНДСПродажПодтвержденный", Comment = "", Synonym = "Виды остатков подтвержденнного НДС по продажам")]
    public class ВидыОстатковНДСПродажПодтвержденный:EnumItem
    {
        public static readonly ВидыОстатковНДСПродажПодтвержденный НеправильноЗарегистрированы = new ВидыОстатковНДСПродажПодтвержденный{Name= "НеправильноЗарегистрированы",Synonim="Неправильно оформленные нал. док-ты (требуется корректировка)",Comment=""};
        public static readonly ВидыОстатковНДСПродажПодтвержденный ВыписаныЗаранее = new ВидыОстатковНДСПродажПодтвержденный{Name= "ВыписаныЗаранее",Synonim="Заранее выписанные нал. док-ты (не требуется корректировка)",Comment=""};
    }
}
