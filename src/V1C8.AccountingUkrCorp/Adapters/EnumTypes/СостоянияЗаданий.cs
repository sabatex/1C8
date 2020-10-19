using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияЗаданий:EnumBase
    {
        public СостоянияЗаданий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Запланировано => GetProperty<EnumItem>("Запланировано");
        public EnumItem Выполняется => GetProperty<EnumItem>("Выполняется");
        public EnumItem Завершено => GetProperty<EnumItem>("Завершено");
        public EnumItem НеЗапланировано => GetProperty<EnumItem>("НеЗапланировано");
        public EnumItem ОшибкаВыполнения => GetProperty<EnumItem>("ОшибкаВыполнения");
        public EnumItem НеАктивно => GetProperty<EnumItem>("НеАктивно");
        public EnumItem ОбработкаОшибкиПриАварийномЗавершении => GetProperty<EnumItem>("ОбработкаОшибкиПриАварийномЗавершении");
    }
}
