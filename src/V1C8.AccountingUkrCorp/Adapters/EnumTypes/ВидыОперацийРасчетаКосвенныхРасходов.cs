using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРасчетаКосвенныхРасходов:V1C8COMObject
    {
        public ВидыОперацийРасчетаКосвенныхРасходов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РаспределениеОбщепроизводственныхРасходов => GetProperty<EnumItemBase>("РаспределениеОбщепроизводственныхРасходов");
        public EnumItemBase РаспределениеОбщехозяйственныхРасходов => GetProperty<EnumItemBase>("РаспределениеОбщехозяйственныхРасходов");
        public EnumItemBase УслугиБезИспользованияПлановыхЦен => GetProperty<EnumItemBase>("УслугиБезИспользованияПлановыхЦен");
        public EnumItemBase ВыпускПродукцииИУслуг => GetProperty<EnumItemBase>("ВыпускПродукцииИУслуг");
    }
}
