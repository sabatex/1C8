using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДействияСНачислением:EnumBase
    {
        public ВидыДействияСНачислением(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Начать => GetProperty<EnumItem>("Начать");
        public EnumItem Изменить => GetProperty<EnumItem>("Изменить");
        public EnumItem НеИзменять => GetProperty<EnumItem>("НеИзменять");
        public EnumItem Прекратить => GetProperty<EnumItem>("Прекратить");
    }
}
