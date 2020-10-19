using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьТипыСкладов:V1C8COMObject
    {
        public УдалитьТипыСкладов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оптовый => GetProperty<EnumItemBase>();
        public EnumItemBase Розничный => GetProperty<EnumItemBase>();
    }
}
