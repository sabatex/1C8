using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыВыполненияУдержаний:V1C8COMObject
    {
        public СпособыВыполненияУдержаний(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЕжемесячноПриОкончательномРасчете => GetProperty<EnumItemBase>();
        public EnumItemBase ПоОтдельномуДокументуДоОкончательногоРасчета => GetProperty<EnumItemBase>();
        public EnumItemBase ПоЗначениюПоказателяПриОкончательномРасчете => GetProperty<EnumItemBase>();
    }
}
