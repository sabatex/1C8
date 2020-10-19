using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПриложение1КНалоговойНакладной:V1C8COMObject
    {
        public ВидыОперацийПриложение1КНалоговойНакладной(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОблагаемыеОперации => GetProperty<EnumItemBase>();
        public EnumItemBase ОсвобожденныеОперации => GetProperty<EnumItemBase>();
        public EnumItemBase НеНДСОперации => GetProperty<EnumItemBase>();
    }
}
