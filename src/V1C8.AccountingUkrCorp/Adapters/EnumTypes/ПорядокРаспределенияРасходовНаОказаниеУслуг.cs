using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРаспределенияРасходовНаОказаниеУслуг:EnumBase
    {
        public ПорядокРаспределенияРасходовНаОказаниеУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоПлановымЦенам => GetProperty<EnumItem>("ПоПлановымЦенам");
        public EnumItem ПоВыручке => GetProperty<EnumItem>("ПоВыручке");
        public EnumItem ПоПлановымЦенамИВыручке => GetProperty<EnumItem>("ПоПлановымЦенамИВыручке");
    }
}
