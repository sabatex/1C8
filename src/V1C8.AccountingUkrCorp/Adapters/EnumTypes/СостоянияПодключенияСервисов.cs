using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияПодключенияСервисов:EnumBase
    {
        public СостоянияПодключенияСервисов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеПодключен => GetProperty<EnumItem>("НеПодключен");
        public EnumItem ОшибкаПодключения => GetProperty<EnumItem>("ОшибкаПодключения");
        public EnumItem Подключен => GetProperty<EnumItem>("Подключен");
        public EnumItem Подключение => GetProperty<EnumItem>("Подключение");
        public EnumItem ПодключениеНедоступно => GetProperty<EnumItem>("ПодключениеНедоступно");
    }
}
