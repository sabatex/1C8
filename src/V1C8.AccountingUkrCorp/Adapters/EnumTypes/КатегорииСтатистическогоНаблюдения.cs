using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСтатистическогоНаблюдения:V1C8COMObject
    {
        public КатегорииСтатистическогоНаблюдения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВыплатаСоциальногоХарактера => GetProperty<EnumItemBase>("ВыплатаСоциальногоХарактера");
        public EnumItemBase ЗаработнаяПлатаРаботников => GetProperty<EnumItemBase>("ЗаработнаяПлатаРаботников");
    }
}
