using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыОценочныхОбязательств:V1C8COMObject
    {
        public ТипыОценочныхОбязательств(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОценочныеОбязательстваПоВознаграждениям => GetProperty<EnumItemBase>();
        public EnumItemBase ОценочныеОбязательстваПоСтраховымВзносам => GetProperty<EnumItemBase>();
        public EnumItemBase ОценочныеОбязательстваПоВзносамФССНСиПЗ => GetProperty<EnumItemBase>();
    }
}
