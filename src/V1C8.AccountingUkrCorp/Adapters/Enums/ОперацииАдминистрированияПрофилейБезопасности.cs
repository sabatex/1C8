using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ОперацииАдминистрированияПрофилейБезопасности:V1C8COMObject
    {
        public ОперацииАдминистрированияПрофилейБезопасности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Создание => GetProperty<EnumItemBase>();
        public EnumItemBase Назначение => GetProperty<EnumItemBase>();
        public EnumItemBase Обновление => GetProperty<EnumItemBase>();
        public EnumItemBase Удаление => GetProperty<EnumItemBase>();
        public EnumItemBase УдалениеНазначения => GetProperty<EnumItemBase>();
    }
}
