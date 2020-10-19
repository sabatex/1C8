using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыЗадолженности:V1C8COMObject
    {
        public ВидыЗадолженности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Дебиторская => GetProperty<EnumItemBase>();
        public EnumItemBase Кредиторская => GetProperty<EnumItemBase>();
    }
}
