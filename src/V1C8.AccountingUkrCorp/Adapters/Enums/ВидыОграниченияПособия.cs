using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОграниченияПособия:V1C8COMObject
    {
        public ВидыОграниченияПособия(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщееОграничение => GetProperty<EnumItemBase>();
        public EnumItemBase ОграничениеВРазмереММОТ => GetProperty<EnumItemBase>();
        public EnumItemBase БезОграничений => GetProperty<EnumItemBase>();
        public EnumItemBase МаксимальныйРазмерЕжемесячнойСтраховойВыплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ОграничениеВРазмереДвухММОТ => GetProperty<EnumItemBase>();
    }
}
