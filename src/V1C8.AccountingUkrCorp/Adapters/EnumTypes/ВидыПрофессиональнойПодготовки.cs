using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПрофессиональнойПодготовки:EnumBase
    {
        public ВидыПрофессиональнойПодготовки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Переподготовка => GetProperty<EnumItem>("Переподготовка");
        public EnumItem ПовышениеКвалификации => GetProperty<EnumItem>("ПовышениеКвалификации");
    }
}
