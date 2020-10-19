using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииДолжностейДляСтатистическогоУчета:V1C8COMObject
    {
        public КатегорииДолжностейДляСтатистическогоУчета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Руководители => GetProperty<EnumItemBase>();
        public EnumItemBase Специалисты => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеСлужащие => GetProperty<EnumItemBase>();
        public EnumItemBase Рабочие => GetProperty<EnumItemBase>();
    }
}
