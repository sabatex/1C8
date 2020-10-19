using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияЗаданий:V1C8COMObject
    {
        public СостоянияЗаданий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Запланировано => GetProperty<EnumItemBase>("Запланировано");
        public EnumItemBase Выполняется => GetProperty<EnumItemBase>("Выполняется");
        public EnumItemBase Завершено => GetProperty<EnumItemBase>("Завершено");
        public EnumItemBase НеЗапланировано => GetProperty<EnumItemBase>("НеЗапланировано");
        public EnumItemBase ОшибкаВыполнения => GetProperty<EnumItemBase>("ОшибкаВыполнения");
        public EnumItemBase НеАктивно => GetProperty<EnumItemBase>("НеАктивно");
        public EnumItemBase ОбработкаОшибкиПриАварийномЗавершении => GetProperty<EnumItemBase>("ОбработкаОшибкиПриАварийномЗавершении");
    }
}
