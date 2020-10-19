using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПлатежейПогашенияЗаймаСотруднику:V1C8COMObject
    {
        public ВидыПлатежейПогашенияЗаймаСотруднику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДифференцированныеПлатежи => GetProperty<EnumItemBase>("ДифференцированныеПлатежи");
        public EnumItemBase АннуитетныеПлатежи => GetProperty<EnumItemBase>("АннуитетныеПлатежи");
        public EnumItemBase ТолькоПроценты => GetProperty<EnumItemBase>("ТолькоПроценты");
        public EnumItemBase ТолькоЗаем => GetProperty<EnumItemBase>("ТолькоЗаем");
    }
}
