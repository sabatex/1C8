using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыФинансированияПособийСоцстрахования:V1C8COMObject
    {
        public СпособыФинансированияПособийСоцстрахования(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаСчетФСС => GetProperty<EnumItemBase>("ЗаСчетФСС");
        public EnumItemBase ЗаСчетРаботодателя => GetProperty<EnumItemBase>("ЗаСчетРаботодателя");
    }
}
