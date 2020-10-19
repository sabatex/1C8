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
    [Table("SposobyVypolnenyiaUderzhanyi")]
    [Description1C8(Name = "СпособыВыполненияУдержаний", Comment = "", Synonym = "Способы выполнения удержаний")]
    public class СпособыВыполненияУдержаний:EnumItem
    {
        public static readonly СпособыВыполненияУдержаний ЕжемесячноПриОкончательномРасчете = new СпособыВыполненияУдержаний{Name= "ЕжемесячноПриОкончательномРасчете",Synonym="Ежемесячно",Comment=""};
        public static readonly СпособыВыполненияУдержаний ПоОтдельномуДокументуДоОкончательногоРасчета = new СпособыВыполненияУдержаний{Name= "ПоОтдельномуДокументуДоОкончательногоРасчета",Synonym="По отдельному документу",Comment=""};
        public static readonly СпособыВыполненияУдержаний ПоЗначениюПоказателяПриОкончательномРасчете = new СпособыВыполненияУдержаний{Name= "ПоЗначениюПоказателяПриОкончательномРасчете",Synonym="Только если введено значение показателя",Comment=""};
    }
}
