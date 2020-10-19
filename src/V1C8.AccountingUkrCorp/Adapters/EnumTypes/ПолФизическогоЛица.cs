using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПолФизическогоЛица:V1C8COMObject
    {
        public ПолФизическогоЛица(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Мужской => GetProperty<EnumItemBase>("Мужской");
        public EnumItemBase Женский => GetProperty<EnumItemBase>("Женский");
    }
}
