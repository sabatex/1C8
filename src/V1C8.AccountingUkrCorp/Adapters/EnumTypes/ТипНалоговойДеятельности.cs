using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипНалоговойДеятельности:V1C8COMObject
    {
        public ТипНалоговойДеятельности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОблагаемыйПоОбычнойСтавке => GetProperty<EnumItemBase>("ОблагаемыйПоОбычнойСтавке");
        public EnumItemBase ОсвобожденныйОтНалогообложения => GetProperty<EnumItemBase>("ОсвобожденныйОтНалогообложения");
        public EnumItemBase НеОблагаемый => GetProperty<EnumItemBase>("НеОблагаемый");
    }
}
