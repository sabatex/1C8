using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтатусыРегламентированныхОтчетов:V1C8COMObject
    {
        public СтатусыРегламентированныхОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Принят => GetProperty<EnumItemBase>();
        public EnumItemBase НеПринят => GetProperty<EnumItemBase>();
        public EnumItemBase ЖдетПодтвержденияСтатуса => GetProperty<EnumItemBase>();
    }
}
