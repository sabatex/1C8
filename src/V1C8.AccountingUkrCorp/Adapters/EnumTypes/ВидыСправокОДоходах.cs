using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСправокОДоходах:EnumBase
    {
        public ВидыСправокОДоходах(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Произвольная => GetProperty<EnumItem>("Произвольная");
        public EnumItem Соцстрах2015 => GetProperty<EnumItem>("Соцстрах2015");
        public EnumItem Субсидия2015 => GetProperty<EnumItem>("Субсидия2015");
        public EnumItem Пенсия2015 => GetProperty<EnumItem>("Пенсия2015");
        public EnumItem ДоходыИНалоги => GetProperty<EnumItem>("ДоходыИНалоги");
        public EnumItem Соцстрах => GetProperty<EnumItem>("Соцстрах");
        public EnumItem Безработица => GetProperty<EnumItem>("Безработица");
        public EnumItem Пенсия => GetProperty<EnumItem>("Пенсия");
        public EnumItem Субсидия => GetProperty<EnumItem>("Субсидия");
    }
}
