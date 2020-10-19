using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыВыполненияУдержаний:V1C8COMObject
    {
        public СпособыВыполненияУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЕжемесячноПриОкончательномРасчете => GetProperty<EnumItemBase>("ЕжемесячноПриОкончательномРасчете");
        public EnumItemBase ПоОтдельномуДокументуДоОкончательногоРасчета => GetProperty<EnumItemBase>("ПоОтдельномуДокументуДоОкончательногоРасчета");
        public EnumItemBase ПоЗначениюПоказателяПриОкончательномРасчете => GetProperty<EnumItemBase>("ПоЗначениюПоказателяПриОкончательномРасчете");
    }
}
