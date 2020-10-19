using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДеятельностиНДС:V1C8COMObject
    {
        public ВидыДеятельностиНДС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Облагаемая => GetProperty<EnumItemBase>("Облагаемая");
        public EnumItemBase Необлагаемая => GetProperty<EnumItemBase>("Необлагаемая");
        public EnumItemBase ПропорциональноОблагаемая => GetProperty<EnumItemBase>("ПропорциональноОблагаемая");
    }
}
