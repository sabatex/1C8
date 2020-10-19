using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг:V1C8COMObject
    {
        public ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоПлановымЦенам => GetProperty<EnumItemBase>("ПоПлановымЦенам");
        public EnumItemBase ПоОбъемуВыпуска => GetProperty<EnumItemBase>("ПоОбъемуВыпуска");
        public EnumItemBase ПоПлановымЦенамИОбъемуВыпуска => GetProperty<EnumItemBase>("ПоПлановымЦенамИОбъемуВыпуска");
    }
}
