using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыРегистрацииВЕРНННалоговыхДокументов:EnumBase
    {
        public СтатусыРегистрацииВЕРНННалоговыхДокументов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеЗарегистрированВЕРНН => GetProperty<EnumItem>("НеЗарегистрированВЕРНН");
        public EnumItem НаправленНаРегистрациюВЕРНН => GetProperty<EnumItem>("НаправленНаРегистрациюВЕРНН");
        public EnumItem ОтказаноВРегистрацииВЕРНН => GetProperty<EnumItem>("ОтказаноВРегистрацииВЕРНН");
        public EnumItem ЗарегистрированВЕРНН => GetProperty<EnumItem>("ЗарегистрированВЕРНН");
    }
}
