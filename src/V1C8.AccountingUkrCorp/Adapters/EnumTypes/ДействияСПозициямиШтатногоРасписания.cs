using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСПозициямиШтатногоРасписания:V1C8COMObject
    {
        public ДействияСПозициямиШтатногоРасписания(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СоздатьНовуюПозицию => GetProperty<EnumItemBase>("СоздатьНовуюПозицию");
        public EnumItemBase ЗакрытьПозицию => GetProperty<EnumItemBase>("ЗакрытьПозицию");
    }
}
