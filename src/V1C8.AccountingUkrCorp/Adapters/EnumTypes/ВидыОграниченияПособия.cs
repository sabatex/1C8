using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОграниченияПособия:EnumBase
    {
        public ВидыОграниченияПособия(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОбщееОграничение => GetProperty<EnumItem>("ОбщееОграничение");
        public EnumItem ОграничениеВРазмереММОТ => GetProperty<EnumItem>("ОграничениеВРазмереММОТ");
        public EnumItem БезОграничений => GetProperty<EnumItem>("БезОграничений");
        public EnumItem МаксимальныйРазмерЕжемесячнойСтраховойВыплаты => GetProperty<EnumItem>("МаксимальныйРазмерЕжемесячнойСтраховойВыплаты");
        public EnumItem ОграничениеВРазмереДвухММОТ => GetProperty<EnumItem>("ОграничениеВРазмереДвухММОТ");
    }
}
