using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыПолейРегистра:V1C8COMObject
    {
        public ТипыПолейРегистра(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Измерение => GetProperty<EnumItemBase>("Измерение");
        public EnumItemBase Ресурс => GetProperty<EnumItemBase>("Ресурс");
        public EnumItemBase Реквизит => GetProperty<EnumItemBase>("Реквизит");
    }
}
