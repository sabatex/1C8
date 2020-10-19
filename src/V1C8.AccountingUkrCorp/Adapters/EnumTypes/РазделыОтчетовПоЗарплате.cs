using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыОтчетовПоЗарплате:V1C8COMObject
    {
        public РазделыОтчетовПоЗарплате(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начисления => GetProperty<EnumItemBase>("Начисления");
        public EnumItemBase Удержания => GetProperty<EnumItemBase>("Удержания");
        public EnumItemBase Выплаты => GetProperty<EnumItemBase>("Выплаты");
        public EnumItemBase ДоходыВНеденежнойФорме => GetProperty<EnumItemBase>("ДоходыВНеденежнойФорме");
        public EnumItemBase ПогашениеЗадолженности => GetProperty<EnumItemBase>("ПогашениеЗадолженности");
    }
}
