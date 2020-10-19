using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыВыполненияНачислений:V1C8COMObject
    {
        public СпособыВыполненияНачислений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЕжемесячноПриОкончательномРасчете => GetProperty<EnumItemBase>();
        public EnumItemBase ПоОтдельномуДокументуДоОкончательногоРасчета => GetProperty<EnumItemBase>();
        public EnumItemBase ВЗаданныхМесяцахПриОкончательномРасчете => GetProperty<EnumItemBase>();
        public EnumItemBase ПоЗначениюПоказателяПриОкончательномРасчете => GetProperty<EnumItemBase>();
        public EnumItemBase ПоЗначениюВидаВремениПриОкончательномРасчете => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаПраздничныеДниПриОкончательномРасчете => GetProperty<EnumItemBase>();
    }
}
