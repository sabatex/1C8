using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПрофессиональнойПодготовки:V1C8COMObject
    {
        public ВидыПрофессиональнойПодготовки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Переподготовка => GetProperty<EnumItemBase>("Переподготовка");
        public EnumItemBase ПовышениеКвалификации => GetProperty<EnumItemBase>("ПовышениеКвалификации");
    }
}
