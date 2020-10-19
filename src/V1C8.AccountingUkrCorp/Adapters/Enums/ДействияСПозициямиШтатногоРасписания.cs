using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ДействияСПозициямиШтатногоРасписания:V1C8COMObject
    {
        public ДействияСПозициямиШтатногоРасписания(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СоздатьНовуюПозицию => GetProperty<EnumItemBase>();
        public EnumItemBase ЗакрытьПозицию => GetProperty<EnumItemBase>();
    }
}
