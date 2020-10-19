using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОценки:EnumBase
    {
        public СпособыОценки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоСредней => GetProperty<EnumItem>("ПоСредней");
        public EnumItem ФИФО => GetProperty<EnumItem>("ФИФО");
        public EnumItem ЛИФО => GetProperty<EnumItem>("ЛИФО");
    }
}
