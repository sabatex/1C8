using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ГруппыНалоговыхНазначений:V1C8COMObject
    {
        public ГруппыНалоговыхНазначений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НалоговыеНазначенияДоНКУ => GetProperty<EnumItemBase>();
        public EnumItemBase НалоговыеНазначенияАктивовИВзаиморасчетовПоНДС => GetProperty<EnumItemBase>();
        public EnumItemBase НалоговыеНазначенияДоходовИЗатрат => GetProperty<EnumItemBase>();
    }
}
