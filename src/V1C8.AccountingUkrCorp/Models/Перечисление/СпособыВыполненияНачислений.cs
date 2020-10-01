using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВыполненияНачислений", Comment = "", Synonym = "Способы выполнения начислений")]
    public enum СпособыВыполненияНачислений
    {
        [Description1C8(Name = "ЕжемесячноПриОкончательномРасчете", Comment = "", Synonym = "Ежемесячно")]
        ЕжемесячноПриОкончательномРасчете,
        [Description1C8(Name = "ПоОтдельномуДокументуДоОкончательногоРасчета", Comment = "", Synonym = "По отдельному документу")]
        ПоОтдельномуДокументуДоОкончательногоРасчета,
        [Description1C8(Name = "ВЗаданныхМесяцахПриОкончательномРасчете", Comment = "", Synonym = "В перечисленных месяцах")]
        ВЗаданныхМесяцахПриОкончательномРасчете,
        [Description1C8(Name = "ПоЗначениюПоказателяПриОкончательномРасчете", Comment = "", Synonym = "Только если введено значение показателя")]
        ПоЗначениюПоказателяПриОкончательномРасчете,
        [Description1C8(Name = "ПоЗначениюВидаВремениПриОкончательномРасчете", Comment = "", Synonym = "Только если введен вид учета времени")]
        ПоЗначениюВидаВремениПриОкончательномРасчете,
        [Description1C8(Name = "ЗаПраздничныеДниПриОкончательномРасчете", Comment = "", Synonym = "Только если время приходится на праздничные дни")]
        ЗаПраздничныеДниПриОкончательномРасчете
    }
}
