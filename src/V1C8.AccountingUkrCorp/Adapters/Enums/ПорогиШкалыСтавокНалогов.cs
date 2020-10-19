using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорогиШкалыСтавокНалогов:V1C8COMObject
    {
        public ПорогиШкалыСтавокНалогов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Порог1 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог2 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог3 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог4 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог5 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог6 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог7 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог8 => GetProperty<EnumItemBase>();
        public EnumItemBase Порог9 => GetProperty<EnumItemBase>();
    }
}
