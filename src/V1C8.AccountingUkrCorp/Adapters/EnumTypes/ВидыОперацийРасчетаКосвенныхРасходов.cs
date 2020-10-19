using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРасчетаКосвенныхРасходов:EnumBase
    {
        public ВидыОперацийРасчетаКосвенныхРасходов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem РаспределениеОбщепроизводственныхРасходов => GetProperty<EnumItem>("РаспределениеОбщепроизводственныхРасходов");
        public EnumItem РаспределениеОбщехозяйственныхРасходов => GetProperty<EnumItem>("РаспределениеОбщехозяйственныхРасходов");
        public EnumItem УслугиБезИспользованияПлановыхЦен => GetProperty<EnumItem>("УслугиБезИспользованияПлановыхЦен");
        public EnumItem ВыпускПродукцииИУслуг => GetProperty<EnumItem>("ВыпускПродукцииИУслуг");
    }
}
