using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВыполненияНачислений", Comment = "", Synonym = "Способы выполнения начислений")]
    public class СпособыВыполненияНачислений:EnumItem
    {
        public static readonly СпособыВыполненияНачислений ЕжемесячноПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ЕжемесячноПриОкончательномРасчете",Synonym="Ежемесячно",Comment=""};
        public static readonly СпособыВыполненияНачислений ПоОтдельномуДокументуДоОкончательногоРасчета = new СпособыВыполненияНачислений{Name= "ПоОтдельномуДокументуДоОкончательногоРасчета",Synonym="По отдельному документу",Comment=""};
        public static readonly СпособыВыполненияНачислений ВЗаданныхМесяцахПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ВЗаданныхМесяцахПриОкончательномРасчете",Synonym="В перечисленных месяцах",Comment=""};
        public static readonly СпособыВыполненияНачислений ПоЗначениюПоказателяПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ПоЗначениюПоказателяПриОкончательномРасчете",Synonym="Только если введено значение показателя",Comment=""};
        public static readonly СпособыВыполненияНачислений ПоЗначениюВидаВремениПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ПоЗначениюВидаВремениПриОкончательномРасчете",Synonym="Только если введен вид учета времени",Comment=""};
        public static readonly СпособыВыполненияНачислений ЗаПраздничныеДниПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ЗаПраздничныеДниПриОкончательномРасчете",Synonym="Только если время приходится на праздничные дни",Comment=""};
    }
}
