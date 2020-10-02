using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВыполненияУдержаний", Comment = "", Synonym = "Способы выполнения удержаний")]
    public class СпособыВыполненияУдержаний:EnumItem
    {
        public static readonly СпособыВыполненияУдержаний ЕжемесячноПриОкончательномРасчете = new СпособыВыполненияУдержаний{Name= "ЕжемесячноПриОкончательномРасчете",Synonim="Ежемесячно",Comment=""};
        public static readonly СпособыВыполненияУдержаний ПоОтдельномуДокументуДоОкончательногоРасчета = new СпособыВыполненияУдержаний{Name= "ПоОтдельномуДокументуДоОкончательногоРасчета",Synonim="По отдельному документу",Comment=""};
        public static readonly СпособыВыполненияУдержаний ПоЗначениюПоказателяПриОкончательномРасчете = new СпособыВыполненияУдержаний{Name= "ПоЗначениюПоказателяПриОкончательномРасчете",Synonim="Только если введено значение показателя",Comment=""};
    }
}
