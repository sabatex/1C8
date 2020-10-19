using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтатусыЛистковСообщения:V1C8COMObject
    {
        public СтатусыЛистковСообщения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеВрученСотруднику => GetProperty<EnumItemBase>();
        public EnumItemBase ВрученСотруднику => GetProperty<EnumItemBase>();
        public EnumItemBase ПредъявленКорешок => GetProperty<EnumItemBase>();
    }
}
