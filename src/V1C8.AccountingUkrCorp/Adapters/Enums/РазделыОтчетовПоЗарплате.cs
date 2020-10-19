using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РазделыОтчетовПоЗарплате:V1C8COMObject
    {
        public РазделыОтчетовПоЗарплате(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начисления => GetProperty<EnumItemBase>();
        public EnumItemBase Удержания => GetProperty<EnumItemBase>();
        public EnumItemBase Выплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ДоходыВНеденежнойФорме => GetProperty<EnumItemBase>();
        public EnumItemBase ПогашениеЗадолженности => GetProperty<EnumItemBase>();
    }
}
