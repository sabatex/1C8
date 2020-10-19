using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияПриОбмене:V1C8COMObject
    {
        public ДействияПриОбмене(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗагрузкаДанных => GetProperty<EnumItemBase>("ЗагрузкаДанных");
        public EnumItemBase ВыгрузкаДанных => GetProperty<EnumItemBase>("ВыгрузкаДанных");
    }
}
