using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОперацииАдминистрированияПрофилейБезопасности:EnumBase
    {
        public ОперацииАдминистрированияПрофилейБезопасности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Создание => GetProperty<EnumItem>("Создание");
        public EnumItem Назначение => GetProperty<EnumItem>("Назначение");
        public EnumItem Обновление => GetProperty<EnumItem>("Обновление");
        public EnumItem Удаление => GetProperty<EnumItem>("Удаление");
        public EnumItem УдалениеНазначения => GetProperty<EnumItem>("УдалениеНазначения");
    }
}
