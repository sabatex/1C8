using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияМиграцииПриложения:V1C8COMObject
    {
        public СостоянияМиграцииПриложения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Выполняется => GetProperty<EnumItemBase>();
        public EnumItemBase ЗавершенаСОшибкой => GetProperty<EnumItemBase>();
        public EnumItemBase ЗавершенаУспешно => GetProperty<EnumItemBase>();
        public EnumItemBase ОжиданиеЗагрузки => GetProperty<EnumItemBase>();
        public EnumItemBase ОжиданиеОбновления => GetProperty<EnumItemBase>();
    }
}
