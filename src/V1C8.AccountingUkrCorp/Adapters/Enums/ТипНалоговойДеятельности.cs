using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипНалоговойДеятельности:V1C8COMObject
    {
        public ТипНалоговойДеятельности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОблагаемыйПоОбычнойСтавке => GetProperty<EnumItemBase>();
        public EnumItemBase ОсвобожденныйОтНалогообложения => GetProperty<EnumItemBase>();
        public EnumItemBase НеОблагаемый => GetProperty<EnumItemBase>();
    }
}
