using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСУдержаниями:EnumBase
    {
        public ДействияСУдержаниями(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Начать => GetProperty<EnumItem>("Начать");
        public EnumItem Изменить => GetProperty<EnumItem>("Изменить");
        public EnumItem Прекратить => GetProperty<EnumItem>("Прекратить");
    }
}
