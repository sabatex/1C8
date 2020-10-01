using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВыполненияУдержаний", Comment = "", Synonym = "Способы выполнения удержаний")]
    public enum СпособыВыполненияУдержаний
    {
        [Description1C8(Name = "ЕжемесячноПриОкончательномРасчете", Comment = "", Synonym = "Ежемесячно")]
        ЕжемесячноПриОкончательномРасчете,
        [Description1C8(Name = "ПоОтдельномуДокументуДоОкончательногоРасчета", Comment = "", Synonym = "По отдельному документу")]
        ПоОтдельномуДокументуДоОкончательногоРасчета,
        [Description1C8(Name = "ПоЗначениюПоказателяПриОкончательномРасчете", Comment = "", Synonym = "Только если введено значение показателя")]
        ПоЗначениюПоказателяПриОкончательномРасчете
    }
}
