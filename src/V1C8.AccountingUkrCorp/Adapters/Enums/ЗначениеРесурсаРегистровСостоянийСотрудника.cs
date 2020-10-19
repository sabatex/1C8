using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ЗначениеРесурсаРегистровСостоянийСотрудника:V1C8COMObject
    {
        public ЗначениеРесурсаРегистровСостоянийСотрудника(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеУстановлено => GetProperty<EnumItemBase>();
        public EnumItemBase Установлено => GetProperty<EnumItemBase>();
        public EnumItemBase УстановленоЗначениеПоУмолчанию => GetProperty<EnumItemBase>();
    }
}
