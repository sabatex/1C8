using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорогиШкалыСтавокНалогов:EnumBase
    {
        public ПорогиШкалыСтавокНалогов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Порог1 => GetProperty<EnumItem>("Порог1");
        public EnumItem Порог2 => GetProperty<EnumItem>("Порог2");
        public EnumItem Порог3 => GetProperty<EnumItem>("Порог3");
        public EnumItem Порог4 => GetProperty<EnumItem>("Порог4");
        public EnumItem Порог5 => GetProperty<EnumItem>("Порог5");
        public EnumItem Порог6 => GetProperty<EnumItem>("Порог6");
        public EnumItem Порог7 => GetProperty<EnumItem>("Порог7");
        public EnumItem Порог8 => GetProperty<EnumItem>("Порог8");
        public EnumItem Порог9 => GetProperty<EnumItem>("Порог9");
    }
}
