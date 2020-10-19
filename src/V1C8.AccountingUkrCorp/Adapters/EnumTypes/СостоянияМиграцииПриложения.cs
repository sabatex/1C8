using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияМиграцииПриложения:EnumBase
    {
        public СостоянияМиграцииПриложения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Выполняется => GetProperty<EnumItem>("Выполняется");
        public EnumItem ЗавершенаСОшибкой => GetProperty<EnumItem>("ЗавершенаСОшибкой");
        public EnumItem ЗавершенаУспешно => GetProperty<EnumItem>("ЗавершенаУспешно");
        public EnumItem ОжиданиеЗагрузки => GetProperty<EnumItem>("ОжиданиеЗагрузки");
        public EnumItem ОжиданиеОбновления => GetProperty<EnumItem>("ОжиданиеОбновления");
    }
}
