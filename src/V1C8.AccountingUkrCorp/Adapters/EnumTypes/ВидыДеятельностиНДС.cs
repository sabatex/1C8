using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДеятельностиНДС:EnumBase
    {
        public ВидыДеятельностиНДС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Облагаемая => GetProperty<EnumItem>("Облагаемая");
        public EnumItem Необлагаемая => GetProperty<EnumItem>("Необлагаемая");
        public EnumItem ПропорциональноОблагаемая => GetProperty<EnumItem>("ПропорциональноОблагаемая");
    }
}
