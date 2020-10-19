using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорогиШкалыСтавокНалогов:V1C8COMObject
    {
        public ПорогиШкалыСтавокНалогов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Порог1 => GetProperty<EnumItemBase>("Порог1");
        public EnumItemBase Порог2 => GetProperty<EnumItemBase>("Порог2");
        public EnumItemBase Порог3 => GetProperty<EnumItemBase>("Порог3");
        public EnumItemBase Порог4 => GetProperty<EnumItemBase>("Порог4");
        public EnumItemBase Порог5 => GetProperty<EnumItemBase>("Порог5");
        public EnumItemBase Порог6 => GetProperty<EnumItemBase>("Порог6");
        public EnumItemBase Порог7 => GetProperty<EnumItemBase>("Порог7");
        public EnumItemBase Порог8 => GetProperty<EnumItemBase>("Порог8");
        public EnumItemBase Порог9 => GetProperty<EnumItemBase>("Порог9");
    }
}
