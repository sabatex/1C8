using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияМиграцииПриложения:V1C8COMObject
    {
        public СостоянияМиграцииПриложения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Выполняется => GetProperty<EnumItemBase>("Выполняется");
        public EnumItemBase ЗавершенаСОшибкой => GetProperty<EnumItemBase>("ЗавершенаСОшибкой");
        public EnumItemBase ЗавершенаУспешно => GetProperty<EnumItemBase>("ЗавершенаУспешно");
        public EnumItemBase ОжиданиеЗагрузки => GetProperty<EnumItemBase>("ОжиданиеЗагрузки");
        public EnumItemBase ОжиданиеОбновления => GetProperty<EnumItemBase>("ОжиданиеОбновления");
    }
}
