using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг:EnumBase
    {
        public ПорядокРаспределенияРасходовНаОказаниеВнутреннихУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоПлановымЦенам => GetProperty<EnumItem>("ПоПлановымЦенам");
        public EnumItem ПоОбъемуВыпуска => GetProperty<EnumItem>("ПоОбъемуВыпуска");
        public EnumItem ПоПлановымЦенамИОбъемуВыпуска => GetProperty<EnumItem>("ПоПлановымЦенамИОбъемуВыпуска");
    }
}
