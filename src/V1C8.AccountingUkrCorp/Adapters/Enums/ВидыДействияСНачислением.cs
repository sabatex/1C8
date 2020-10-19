using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДействияСНачислением:V1C8COMObject
    {
        public ВидыДействияСНачислением(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начать => GetProperty<EnumItemBase>();
        public EnumItemBase Изменить => GetProperty<EnumItemBase>();
        public EnumItemBase НеИзменять => GetProperty<EnumItemBase>();
        public EnumItemBase Прекратить => GetProperty<EnumItemBase>();
    }
}
