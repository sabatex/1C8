using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРасчетаСебестоимости:V1C8COMObject
    {
        public ВидыОперацийРасчетаСебестоимости(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РасходыНаПроизводствоПродукцииИУслуг => GetProperty<EnumItemBase>("РасходыНаПроизводствоПродукцииИУслуг");
        public EnumItemBase УслугиБезИспользованияПлановыхЦен => GetProperty<EnumItemBase>("УслугиБезИспользованияПлановыхЦен");
        public EnumItemBase ВыпускПродукцииИУслуг => GetProperty<EnumItemBase>("ВыпускПродукцииИУслуг");
    }
}
