using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class МоментыОпределенияНалоговойБазы:V1C8COMObject
    {
        public МоментыОпределенияНалоговойБазы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоОплате => GetProperty<EnumItemBase>("ПоОплате");
        public EnumItemBase ПоОтгрузке => GetProperty<EnumItemBase>("ПоОтгрузке");
        public EnumItemBase ПоПервомуСобытию => GetProperty<EnumItemBase>("ПоПервомуСобытию");
        public EnumItemBase НеОпределять => GetProperty<EnumItemBase>("НеОпределять");
    }
}
