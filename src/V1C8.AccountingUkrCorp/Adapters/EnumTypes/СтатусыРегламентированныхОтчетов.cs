using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыРегламентированныхОтчетов:EnumBase
    {
        public СтатусыРегламентированныхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Принят => GetProperty<EnumItem>("Принят");
        public EnumItem НеПринят => GetProperty<EnumItem>("НеПринят");
        public EnumItem ЖдетПодтвержденияСтатуса => GetProperty<EnumItem>("ЖдетПодтвержденияСтатуса");
    }
}
