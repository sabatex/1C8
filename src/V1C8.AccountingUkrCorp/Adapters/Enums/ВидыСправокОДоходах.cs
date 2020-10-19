using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыСправокОДоходах:V1C8COMObject
    {
        public ВидыСправокОДоходах(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Произвольная => GetProperty<EnumItemBase>();
        public EnumItemBase Соцстрах2015 => GetProperty<EnumItemBase>();
        public EnumItemBase Субсидия2015 => GetProperty<EnumItemBase>();
        public EnumItemBase Пенсия2015 => GetProperty<EnumItemBase>();
        public EnumItemBase ДоходыИНалоги => GetProperty<EnumItemBase>();
        public EnumItemBase Соцстрах => GetProperty<EnumItemBase>();
        public EnumItemBase Безработица => GetProperty<EnumItemBase>();
        public EnumItemBase Пенсия => GetProperty<EnumItemBase>();
        public EnumItemBase Субсидия => GetProperty<EnumItemBase>();
    }
}
