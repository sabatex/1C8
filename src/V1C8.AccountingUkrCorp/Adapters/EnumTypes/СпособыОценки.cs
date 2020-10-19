using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОценки:V1C8COMObject
    {
        public СпособыОценки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоСредней => GetProperty<EnumItemBase>("ПоСредней");
        public EnumItemBase ФИФО => GetProperty<EnumItemBase>("ФИФО");
        public EnumItemBase ЛИФО => GetProperty<EnumItemBase>("ЛИФО");
    }
}
