using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class МетодыРаспределенияРБП:EnumBase
    {
        public МетодыРаспределенияРБП(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоДням => GetProperty<EnumItem>("ПоДням");
        public EnumItem ПоМесяцам => GetProperty<EnumItem>("ПоМесяцам");
    }
}
