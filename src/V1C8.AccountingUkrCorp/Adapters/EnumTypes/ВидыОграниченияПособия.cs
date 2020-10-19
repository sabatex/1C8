using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОграниченияПособия:V1C8COMObject
    {
        public ВидыОграниченияПособия(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщееОграничение => GetProperty<EnumItemBase>("ОбщееОграничение");
        public EnumItemBase ОграничениеВРазмереММОТ => GetProperty<EnumItemBase>("ОграничениеВРазмереММОТ");
        public EnumItemBase БезОграничений => GetProperty<EnumItemBase>("БезОграничений");
        public EnumItemBase МаксимальныйРазмерЕжемесячнойСтраховойВыплаты => GetProperty<EnumItemBase>("МаксимальныйРазмерЕжемесячнойСтраховойВыплаты");
        public EnumItemBase ОграничениеВРазмереДвухММОТ => GetProperty<EnumItemBase>("ОграничениеВРазмереДвухММОТ");
    }
}
