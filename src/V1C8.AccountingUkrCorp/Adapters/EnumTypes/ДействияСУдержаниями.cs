using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДействияСУдержаниями:V1C8COMObject
    {
        public ДействияСУдержаниями(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начать => GetProperty<EnumItemBase>("Начать");
        public EnumItemBase Изменить => GetProperty<EnumItemBase>("Изменить");
        public EnumItemBase Прекратить => GetProperty<EnumItemBase>("Прекратить");
    }
}
