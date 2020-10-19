using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияЗаданий:V1C8COMObject
    {
        public СостоянияЗаданий(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Запланировано => GetProperty<EnumItemBase>();
        public EnumItemBase Выполняется => GetProperty<EnumItemBase>();
        public EnumItemBase Завершено => GetProperty<EnumItemBase>();
        public EnumItemBase НеЗапланировано => GetProperty<EnumItemBase>();
        public EnumItemBase ОшибкаВыполнения => GetProperty<EnumItemBase>();
        public EnumItemBase НеАктивно => GetProperty<EnumItemBase>();
        public EnumItemBase ОбработкаОшибкиПриАварийномЗавершении => GetProperty<EnumItemBase>();
    }
}
