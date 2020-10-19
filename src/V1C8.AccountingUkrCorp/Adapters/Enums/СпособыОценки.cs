using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыОценки:V1C8COMObject
    {
        public СпособыОценки(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоСредней => GetProperty<EnumItemBase>();
        public EnumItemBase ФИФО => GetProperty<EnumItemBase>();
        public EnumItemBase ЛИФО => GetProperty<EnumItemBase>();
    }
}
