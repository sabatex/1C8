using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыНалоговыхНазначений:V1C8COMObject
    {
        public ГруппыНалоговыхНазначений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НалоговыеНазначенияДоНКУ => GetProperty<EnumItemBase>("НалоговыеНазначенияДоНКУ");
        public EnumItemBase НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС => GetProperty<EnumItemBase>("НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС");
        public EnumItemBase НалоговыеНазначенияДоходовИЗатрат => GetProperty<EnumItemBase>("НалоговыеНазначенияДоходовИЗатрат");
    }
}
