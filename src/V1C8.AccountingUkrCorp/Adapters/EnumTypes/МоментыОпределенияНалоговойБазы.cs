using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class МоментыОпределенияНалоговойБазы:EnumBase
    {
        public МоментыОпределенияНалоговойБазы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоОплате => GetProperty<EnumItem>("ПоОплате");
        public EnumItem ПоОтгрузке => GetProperty<EnumItem>("ПоОтгрузке");
        public EnumItem ПоПервомуСобытию => GetProperty<EnumItem>("ПоПервомуСобытию");
        public EnumItem НеОпределять => GetProperty<EnumItem>("НеОпределять");
    }
}
