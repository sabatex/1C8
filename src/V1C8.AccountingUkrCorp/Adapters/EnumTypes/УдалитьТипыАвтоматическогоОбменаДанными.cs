using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьТипыАвтоматическогоОбменаДанными:EnumBase
    {
        public УдалитьТипыАвтоматическогоОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОбменЧерезФайловыйРесурс => GetProperty<EnumItem>("ОбменЧерезФайловыйРесурс");
        public EnumItem ОбменЧерезFTPРесурс => GetProperty<EnumItem>("ОбменЧерезFTPРесурс");
        public EnumItem ОбменЧерезПочту => GetProperty<EnumItem>("ОбменЧерезПочту");
        public EnumItem ОбменЧерезComСоединение => GetProperty<EnumItem>("ОбменЧерезComСоединение");
    }
}
