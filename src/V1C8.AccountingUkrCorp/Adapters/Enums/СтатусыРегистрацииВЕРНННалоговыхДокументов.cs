using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтатусыРегистрацииВЕРНННалоговыхДокументов:V1C8COMObject
    {
        public СтатусыРегистрацииВЕРНННалоговыхДокументов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеЗарегистрированВЕРНН => GetProperty<EnumItemBase>();
        public EnumItemBase НаправленНаРегистрациюВЕРНН => GetProperty<EnumItemBase>();
        public EnumItemBase ОтказаноВРегистрацииВЕРНН => GetProperty<EnumItemBase>();
        public EnumItemBase ЗарегистрированВЕРНН => GetProperty<EnumItemBase>();
    }
}
