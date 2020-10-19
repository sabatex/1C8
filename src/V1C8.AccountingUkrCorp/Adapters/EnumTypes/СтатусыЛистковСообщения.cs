using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыЛистковСообщения:EnumBase
    {
        public СтатусыЛистковСообщения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеВрученСотруднику => GetProperty<EnumItem>("НеВрученСотруднику");
        public EnumItem ВрученСотруднику => GetProperty<EnumItem>("ВрученСотруднику");
        public EnumItem ПредъявленКорешок => GetProperty<EnumItem>("ПредъявленКорешок");
    }
}
