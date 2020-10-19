using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипНалоговойДеятельности:EnumBase
    {
        public ТипНалоговойДеятельности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОблагаемыйПоОбычнойСтавке => GetProperty<EnumItem>("ОблагаемыйПоОбычнойСтавке");
        public EnumItem ОсвобожденныйОтНалогообложения => GetProperty<EnumItem>("ОсвобожденныйОтНалогообложения");
        public EnumItem НеОблагаемый => GetProperty<EnumItem>("НеОблагаемый");
    }
}
