using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСПозициямиШтатногоРасписания:EnumBase
    {
        public ДействияСПозициямиШтатногоРасписания(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СоздатьНовуюПозицию => GetProperty<EnumItem>("СоздатьНовуюПозицию");
        public EnumItem ЗакрытьПозицию => GetProperty<EnumItem>("ЗакрытьПозицию");
    }
}
