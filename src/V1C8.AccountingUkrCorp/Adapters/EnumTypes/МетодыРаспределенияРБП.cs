using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class МетодыРаспределенияРБП:V1C8COMObject
    {
        public МетодыРаспределенияРБП(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоДням => GetProperty<EnumItemBase>("ПоДням");
        public EnumItemBase ПоМесяцам => GetProperty<EnumItemBase>("ПоМесяцам");
    }
}
