using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЗначениеРесурсаРегистровСостоянийСотрудника:V1C8COMObject
    {
        public ЗначениеРесурсаРегистровСостоянийСотрудника(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеУстановлено => GetProperty<EnumItemBase>("НеУстановлено");
        public EnumItemBase Установлено => GetProperty<EnumItemBase>("Установлено");
        public EnumItemBase УстановленоЗначениеПоУмолчанию => GetProperty<EnumItemBase>("УстановленоЗначениеПоУмолчанию");
    }
}
