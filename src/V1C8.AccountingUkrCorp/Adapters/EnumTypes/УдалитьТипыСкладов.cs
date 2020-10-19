using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьТипыСкладов:V1C8COMObject
    {
        public УдалитьТипыСкладов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оптовый => GetProperty<EnumItemBase>("Оптовый");
        public EnumItemBase Розничный => GetProperty<EnumItemBase>("Розничный");
    }
}
