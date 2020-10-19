using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияПодключенияСервисов:V1C8COMObject
    {
        public СостоянияПодключенияСервисов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеПодключен => GetProperty<EnumItemBase>();
        public EnumItemBase ОшибкаПодключения => GetProperty<EnumItemBase>();
        public EnumItemBase Подключен => GetProperty<EnumItemBase>();
        public EnumItemBase Подключение => GetProperty<EnumItemBase>();
        public EnumItemBase ПодключениеНедоступно => GetProperty<EnumItemBase>();
    }
}
