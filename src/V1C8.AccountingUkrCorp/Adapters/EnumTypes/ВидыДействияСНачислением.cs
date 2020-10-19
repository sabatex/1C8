using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДействияСНачислением:V1C8COMObject
    {
        public ВидыДействияСНачислением(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начать => GetProperty<EnumItemBase>("Начать");
        public EnumItemBase Изменить => GetProperty<EnumItemBase>("Изменить");
        public EnumItemBase НеИзменять => GetProperty<EnumItemBase>("НеИзменять");
        public EnumItemBase Прекратить => GetProperty<EnumItemBase>("Прекратить");
    }
}
