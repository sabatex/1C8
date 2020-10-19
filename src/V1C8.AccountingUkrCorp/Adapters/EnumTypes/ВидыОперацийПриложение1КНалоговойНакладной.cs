using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПриложение1КНалоговойНакладной:EnumBase
    {
        public ВидыОперацийПриложение1КНалоговойНакладной(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОблагаемыеОперации => GetProperty<EnumItem>("ОблагаемыеОперации");
        public EnumItem ОсвобожденныеОперации => GetProperty<EnumItem>("ОсвобожденныеОперации");
        public EnumItem НеНДСОперации => GetProperty<EnumItem>("НеНДСОперации");
    }
}
