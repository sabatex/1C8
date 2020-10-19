using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыВыполненияНачислений:EnumBase
    {
        public СпособыВыполненияНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЕжемесячноПриОкончательномРасчете => GetProperty<EnumItem>("ЕжемесячноПриОкончательномРасчете");
        public EnumItem ПоОтдельномуДокументуДоОкончательногоРасчета => GetProperty<EnumItem>("ПоОтдельномуДокументуДоОкончательногоРасчета");
        public EnumItem ВЗаданныхМесяцахПриОкончательномРасчете => GetProperty<EnumItem>("ВЗаданныхМесяцахПриОкончательномРасчете");
        public EnumItem ПоЗначениюПоказателяПриОкончательномРасчете => GetProperty<EnumItem>("ПоЗначениюПоказателяПриОкончательномРасчете");
        public EnumItem ПоЗначениюВидаВремениПриОкончательномРасчете => GetProperty<EnumItem>("ПоЗначениюВидаВремениПриОкончательномРасчете");
        public EnumItem ЗаПраздничныеДниПриОкончательномРасчете => GetProperty<EnumItem>("ЗаПраздничныеДниПриОкончательномРасчете");
    }
}
