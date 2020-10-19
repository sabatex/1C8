using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьТипыАвтоматическогоОбменаДанными:V1C8COMObject
    {
        public УдалитьТипыАвтоматическогоОбменаДанными(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбменЧерезФайловыйРесурс => GetProperty<EnumItemBase>();
        public EnumItemBase ОбменЧерезFTPРесурс => GetProperty<EnumItemBase>();
        public EnumItemBase ОбменЧерезПочту => GetProperty<EnumItemBase>();
        public EnumItemBase ОбменЧерезComСоединение => GetProperty<EnumItemBase>();
    }
}
