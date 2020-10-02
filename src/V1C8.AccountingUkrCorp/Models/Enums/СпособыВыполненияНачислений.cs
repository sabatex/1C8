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
        public static readonly СпособыВыполненияНачислений ЕжемесячноПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ЕжемесячноПриОкончательномРасчете",Synonim="Ежемесячно",Comment=""};
        public static readonly СпособыВыполненияНачислений ПоОтдельномуДокументуДоОкончательногоРасчета = new СпособыВыполненияНачислений{Name= "ПоОтдельномуДокументуДоОкончательногоРасчета",Synonim="По отдельному документу",Comment=""};
        public static readonly СпособыВыполненияНачислений ВЗаданныхМесяцахПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ВЗаданныхМесяцахПриОкончательномРасчете",Synonim="В перечисленных месяцах",Comment=""};
        public static readonly СпособыВыполненияНачислений ПоЗначениюПоказателяПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ПоЗначениюПоказателяПриОкончательномРасчете",Synonim="Только если введено значение показателя",Comment=""};
        public static readonly СпособыВыполненияНачислений ПоЗначениюВидаВремениПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ПоЗначениюВидаВремениПриОкончательномРасчете",Synonim="Только если введен вид учета времени",Comment=""};
        public static readonly СпособыВыполненияНачислений ЗаПраздничныеДниПриОкончательномРасчете = new СпособыВыполненияНачислений{Name= "ЗаПраздничныеДниПриОкончательномРасчете",Synonim="Только если время приходится на праздничные дни",Comment=""};
    }
}
