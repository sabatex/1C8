using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыЛистковСообщения:V1C8COMObject
    {
        public СтатусыЛистковСообщения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеВрученСотруднику => GetProperty<EnumItemBase>("НеВрученСотруднику");
        public EnumItemBase ВрученСотруднику => GetProperty<EnumItemBase>("ВрученСотруднику");
        public EnumItemBase ПредъявленКорешок => GetProperty<EnumItemBase>("ПредъявленКорешок");
    }
}
