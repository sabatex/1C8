using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыОценкиСтоимостиВстречногоВыпуска:V1C8COMObject
    {
        public СпособыОценкиСтоимостиВстречногоВыпуска(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоРасчетнойСтоимости => GetProperty<EnumItemBase>();
        public EnumItemBase НеРассчитывается => GetProperty<EnumItemBase>();
    }
}
