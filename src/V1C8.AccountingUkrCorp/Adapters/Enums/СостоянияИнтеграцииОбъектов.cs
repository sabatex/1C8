using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияИнтеграцииОбъектов:V1C8COMObject
    {
        public СостоянияИнтеграцииОбъектов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Ожидание => GetProperty<EnumItemBase>();
        public EnumItemBase Интегрирован => GetProperty<EnumItemBase>();
        public EnumItemBase Ошибка => GetProperty<EnumItemBase>();
    }
}
