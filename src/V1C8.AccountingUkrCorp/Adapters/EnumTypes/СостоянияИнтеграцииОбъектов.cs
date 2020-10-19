using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияИнтеграцииОбъектов:EnumBase
    {
        public СостоянияИнтеграцииОбъектов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Ожидание => GetProperty<EnumItem>("Ожидание");
        public EnumItem Интегрирован => GetProperty<EnumItem>("Интегрирован");
        public EnumItem Ошибка => GetProperty<EnumItem>("Ошибка");
    }
}
