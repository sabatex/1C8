using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УстарелоВидыПропорцииВремени:V1C8COMObject
    {
        public УстарелоВидыПропорцииВремени(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоДням => GetProperty<EnumItemBase>("ПоДням");
        public EnumItemBase ПоЧасам => GetProperty<EnumItemBase>("ПоЧасам");
    }
}
