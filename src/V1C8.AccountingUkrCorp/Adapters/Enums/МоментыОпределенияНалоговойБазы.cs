using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class МоментыОпределенияНалоговойБазы:V1C8COMObject
    {
        public МоментыОпределенияНалоговойБазы(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоОплате => GetProperty<EnumItemBase>();
        public EnumItemBase ПоОтгрузке => GetProperty<EnumItemBase>();
        public EnumItemBase ПоПервомуСобытию => GetProperty<EnumItemBase>();
        public EnumItemBase НеОпределять => GetProperty<EnumItemBase>();
    }
}
