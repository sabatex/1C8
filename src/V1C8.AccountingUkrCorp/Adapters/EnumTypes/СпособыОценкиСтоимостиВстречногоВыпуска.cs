using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОценкиСтоимостиВстречногоВыпуска:V1C8COMObject
    {
        public СпособыОценкиСтоимостиВстречногоВыпуска(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоРасчетнойСтоимости => GetProperty<EnumItemBase>("ПоРасчетнойСтоимости");
        public EnumItemBase НеРассчитывается => GetProperty<EnumItemBase>("НеРассчитывается");
    }
}
