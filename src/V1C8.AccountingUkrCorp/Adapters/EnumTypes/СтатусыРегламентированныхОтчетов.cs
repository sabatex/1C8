using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыРегламентированныхОтчетов:V1C8COMObject
    {
        public СтатусыРегламентированныхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Принят => GetProperty<EnumItemBase>("Принят");
        public EnumItemBase НеПринят => GetProperty<EnumItemBase>("НеПринят");
        public EnumItemBase ЖдетПодтвержденияСтатуса => GetProperty<EnumItemBase>("ЖдетПодтвержденияСтатуса");
    }
}
