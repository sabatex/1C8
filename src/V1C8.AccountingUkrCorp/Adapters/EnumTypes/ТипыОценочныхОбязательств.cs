using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыОценочныхОбязательств:V1C8COMObject
    {
        public ТипыОценочныхОбязательств(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОценочныеОбязательстваПоВознаграждениям => GetProperty<EnumItemBase>("ОценочныеОбязательстваПоВознаграждениям");
        public EnumItemBase ОценочныеОбязательстваПоСтраховымВзносам => GetProperty<EnumItemBase>("ОценочныеОбязательстваПоСтраховымВзносам");
        public EnumItemBase ОценочныеОбязательстваПоВзносамФССНСиПЗ => GetProperty<EnumItemBase>("ОценочныеОбязательстваПоВзносамФССНСиПЗ");
    }
}
