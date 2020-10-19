using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыПлатежейПогашенияЗаймаСотруднику:V1C8COMObject
    {
        public ВидыПлатежейПогашенияЗаймаСотруднику(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДифференцированныеПлатежи => GetProperty<EnumItemBase>();
        public EnumItemBase АннуитетныеПлатежи => GetProperty<EnumItemBase>();
        public EnumItemBase ТолькоПроценты => GetProperty<EnumItemBase>();
        public EnumItemBase ТолькоЗаем => GetProperty<EnumItemBase>();
    }
}
