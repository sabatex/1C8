using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОстатковНДСПродажОжидаемый", Comment = "", Synonym = "Виды остатков ожидаемого НДС по продажам")]
    public class ВидыОстатковНДСПродажОжидаемый:EnumItem
    {
        public static readonly ВидыОстатковНДСПродажОжидаемый ПравильнаяРегистрация = new ВидыОстатковНДСПродажОжидаемый{Name= "ПравильнаяРегистрация",Synonim="Правильное оформление нал. док-тов (корректируют неправильно оформленные)",Comment=""};
        public static readonly ВидыОстатковНДСПродажОжидаемый ЕщеНеВыписаны = new ВидыОстатковНДСПродажОжидаемый{Name= "ЕщеНеВыписаны",Synonim="Еще не выписанные нал. док-ты (не требуется корректировки)",Comment=""};
    }
}
