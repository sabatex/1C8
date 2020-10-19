using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСтатистическогоНаблюдения:EnumBase
    {
        public КатегорииСтатистическогоНаблюдения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВыплатаСоциальногоХарактера => GetProperty<EnumItem>("ВыплатаСоциальногоХарактера");
        public EnumItem ЗаработнаяПлатаРаботников => GetProperty<EnumItem>("ЗаработнаяПлатаРаботников");
    }
}
