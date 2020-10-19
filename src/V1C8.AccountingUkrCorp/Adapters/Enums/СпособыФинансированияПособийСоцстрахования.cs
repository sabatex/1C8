using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыФинансированияПособийСоцстрахования:V1C8COMObject
    {
        public СпособыФинансированияПособийСоцстрахования(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаСчетФСС => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаСчетРаботодателя => GetProperty<EnumItemBase>();
    }
}
