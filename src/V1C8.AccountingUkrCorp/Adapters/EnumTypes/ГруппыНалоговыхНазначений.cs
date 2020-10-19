using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыНалоговыхНазначений:EnumBase
    {
        public ГруппыНалоговыхНазначений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НалоговыеНазначенияДоНКУ => GetProperty<EnumItem>("НалоговыеНазначенияДоНКУ");
        public EnumItem НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС => GetProperty<EnumItem>("НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС");
        public EnumItem НалоговыеНазначенияДоходовИЗатрат => GetProperty<EnumItem>("НалоговыеНазначенияДоходовИЗатрат");
    }
}
