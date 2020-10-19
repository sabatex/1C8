using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыОценочныхОбязательств:EnumBase
    {
        public ТипыОценочныхОбязательств(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОценочныеОбязательстваПоВознаграждениям => GetProperty<EnumItem>("ОценочныеОбязательстваПоВознаграждениям");
        public EnumItem ОценочныеОбязательстваПоСтраховымВзносам => GetProperty<EnumItem>("ОценочныеОбязательстваПоСтраховымВзносам");
        public EnumItem ОценочныеОбязательстваПоВзносамФССНСиПЗ => GetProperty<EnumItem>("ОценочныеОбязательстваПоВзносамФССНСиПЗ");
    }
}
