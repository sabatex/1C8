using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДеятельностиНДС:V1C8COMObject
    {
        public ВидыДеятельностиНДС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Облагаемая => GetProperty<EnumItemBase>();
        public EnumItemBase Необлагаемая => GetProperty<EnumItemBase>();
        public EnumItemBase ПропорциональноОблагаемая => GetProperty<EnumItemBase>();
    }
}
