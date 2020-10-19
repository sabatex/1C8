using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииДолжностейДляСтатистическогоУчета:V1C8COMObject
    {
        public КатегорииДолжностейДляСтатистическогоУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Руководители => GetProperty<EnumItemBase>("Руководители");
        public EnumItemBase Специалисты => GetProperty<EnumItemBase>("Специалисты");
        public EnumItemBase ДругиеСлужащие => GetProperty<EnumItemBase>("ДругиеСлужащие");
        public EnumItemBase Рабочие => GetProperty<EnumItemBase>("Рабочие");
    }
}
