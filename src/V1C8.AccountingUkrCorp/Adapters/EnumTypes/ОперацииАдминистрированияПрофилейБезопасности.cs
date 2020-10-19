using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОперацииАдминистрированияПрофилейБезопасности:V1C8COMObject
    {
        public ОперацииАдминистрированияПрофилейБезопасности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Создание => GetProperty<EnumItemBase>("Создание");
        public EnumItemBase Назначение => GetProperty<EnumItemBase>("Назначение");
        public EnumItemBase Обновление => GetProperty<EnumItemBase>("Обновление");
        public EnumItemBase Удаление => GetProperty<EnumItemBase>("Удаление");
        public EnumItemBase УдалениеНазначения => GetProperty<EnumItemBase>("УдалениеНазначения");
    }
}
