using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОценкиСтоимостиВстречногоВыпуска:EnumBase
    {
        public СпособыОценкиСтоимостиВстречногоВыпуска(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоРасчетнойСтоимости => GetProperty<EnumItem>("ПоРасчетнойСтоимости");
        public EnumItem НеРассчитывается => GetProperty<EnumItem>("НеРассчитывается");
    }
}
