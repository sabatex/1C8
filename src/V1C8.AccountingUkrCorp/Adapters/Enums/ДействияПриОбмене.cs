using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ДействияПриОбмене:V1C8COMObject
    {
        public ДействияПриОбмене(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗагрузкаДанных => GetProperty<EnumItemBase>();
        public EnumItemBase ВыгрузкаДанных => GetProperty<EnumItemBase>();
    }
}
