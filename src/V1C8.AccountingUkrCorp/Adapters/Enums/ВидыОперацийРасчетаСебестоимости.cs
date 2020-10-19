using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийРасчетаСебестоимости:V1C8COMObject
    {
        public ВидыОперацийРасчетаСебестоимости(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РасходыНаПроизводствоПродукцииИУслуг => GetProperty<EnumItemBase>();
        public EnumItemBase УслугиБезИспользованияПлановыхЦен => GetProperty<EnumItemBase>();
        public EnumItemBase ВыпускПродукцииИУслуг => GetProperty<EnumItemBase>();
    }
}
