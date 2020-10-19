using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыОтчетовПоЗарплате:EnumBase
    {
        public РазделыОтчетовПоЗарплате(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Начисления => GetProperty<EnumItem>("Начисления");
        public EnumItem Удержания => GetProperty<EnumItem>("Удержания");
        public EnumItem Выплаты => GetProperty<EnumItem>("Выплаты");
        public EnumItem ДоходыВНеденежнойФорме => GetProperty<EnumItem>("ДоходыВНеденежнойФорме");
        public EnumItem ПогашениеЗадолженности => GetProperty<EnumItem>("ПогашениеЗадолженности");
    }
}
