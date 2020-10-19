using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияПодключенияСервисов:V1C8COMObject
    {
        public СостоянияПодключенияСервисов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеПодключен => GetProperty<EnumItemBase>("НеПодключен");
        public EnumItemBase ОшибкаПодключения => GetProperty<EnumItemBase>("ОшибкаПодключения");
        public EnumItemBase Подключен => GetProperty<EnumItemBase>("Подключен");
        public EnumItemBase Подключение => GetProperty<EnumItemBase>("Подключение");
        public EnumItemBase ПодключениеНедоступно => GetProperty<EnumItemBase>("ПодключениеНедоступно");
    }
}
