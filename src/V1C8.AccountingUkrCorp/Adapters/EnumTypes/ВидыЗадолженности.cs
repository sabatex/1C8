using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыЗадолженности:V1C8COMObject
    {
        public ВидыЗадолженности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Дебиторская => GetProperty<EnumItemBase>("Дебиторская");
        public EnumItemBase Кредиторская => GetProperty<EnumItemBase>("Кредиторская");
    }
}
