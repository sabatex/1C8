using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПриложение1КНалоговойНакладной:V1C8COMObject
    {
        public ВидыОперацийПриложение1КНалоговойНакладной(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОблагаемыеОперации => GetProperty<EnumItemBase>("ОблагаемыеОперации");
        public EnumItemBase ОсвобожденныеОперации => GetProperty<EnumItemBase>("ОсвобожденныеОперации");
        public EnumItemBase НеНДСОперации => GetProperty<EnumItemBase>("НеНДСОперации");
    }
}
