using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыПолейРегистра:EnumBase
    {
        public ТипыПолейРегистра(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Измерение => GetProperty<EnumItem>("Измерение");
        public EnumItem Ресурс => GetProperty<EnumItem>("Ресурс");
        public EnumItem Реквизит => GetProperty<EnumItem>("Реквизит");
    }
}
