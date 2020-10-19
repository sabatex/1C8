using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыМонетарныхСтатейВВалюте:V1C8COMObject
    {
        public ВидыМонетарныхСтатейВВалюте(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеоперационнаяДеятельность => GetProperty<EnumItemBase>();
        public EnumItemBase ОбязательстваУчредителей => GetProperty<EnumItemBase>();
    }
}
