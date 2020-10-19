using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСправокОДоходах:V1C8COMObject
    {
        public ВидыСправокОДоходах(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Произвольная => GetProperty<EnumItemBase>("Произвольная");
        public EnumItemBase Соцстрах2015 => GetProperty<EnumItemBase>("Соцстрах2015");
        public EnumItemBase Субсидия2015 => GetProperty<EnumItemBase>("Субсидия2015");
        public EnumItemBase Пенсия2015 => GetProperty<EnumItemBase>("Пенсия2015");
        public EnumItemBase ДоходыИНалоги => GetProperty<EnumItemBase>("ДоходыИНалоги");
        public EnumItemBase Соцстрах => GetProperty<EnumItemBase>("Соцстрах");
        public EnumItemBase Безработица => GetProperty<EnumItemBase>("Безработица");
        public EnumItemBase Пенсия => GetProperty<EnumItemBase>("Пенсия");
        public EnumItemBase Субсидия => GetProperty<EnumItemBase>("Субсидия");
    }
}
