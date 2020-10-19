using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьТипыАвтоматическогоОбменаДанными:V1C8COMObject
    {
        public УдалитьТипыАвтоматическогоОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбменЧерезФайловыйРесурс => GetProperty<EnumItemBase>("ОбменЧерезФайловыйРесурс");
        public EnumItemBase ОбменЧерезFTPРесурс => GetProperty<EnumItemBase>("ОбменЧерезFTPРесурс");
        public EnumItemBase ОбменЧерезПочту => GetProperty<EnumItemBase>("ОбменЧерезПочту");
        public EnumItemBase ОбменЧерезComСоединение => GetProperty<EnumItemBase>("ОбменЧерезComСоединение");
    }
}
