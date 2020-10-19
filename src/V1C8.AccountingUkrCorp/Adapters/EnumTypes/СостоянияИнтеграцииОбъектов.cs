using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияИнтеграцииОбъектов:V1C8COMObject
    {
        public СостоянияИнтеграцииОбъектов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Ожидание => GetProperty<EnumItemBase>("Ожидание");
        public EnumItemBase Интегрирован => GetProperty<EnumItemBase>("Интегрирован");
        public EnumItemBase Ошибка => GetProperty<EnumItemBase>("Ошибка");
    }
}
