using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПлатежейПогашенияЗаймаСотруднику:EnumBase
    {
        public ВидыПлатежейПогашенияЗаймаСотруднику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДифференцированныеПлатежи => GetProperty<EnumItem>("ДифференцированныеПлатежи");
        public EnumItem АннуитетныеПлатежи => GetProperty<EnumItem>("АннуитетныеПлатежи");
        public EnumItem ТолькоПроценты => GetProperty<EnumItem>("ТолькоПроценты");
        public EnumItem ТолькоЗаем => GetProperty<EnumItem>("ТолькоЗаем");
    }
}
