using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыПодтверждающихДокументовОтпускаПоУходу:V1C8COMObject
    {
        public ВидыПодтверждающихДокументовОтпускаПоУходу(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СвидетельствоОРождении => GetProperty<EnumItemBase>();
        public EnumItemBase РешениеОбУстановленииОпеки => GetProperty<EnumItemBase>();
        public EnumItemBase ИнойДокументПодтверждающийРождениеРебенка => GetProperty<EnumItemBase>();
        public EnumItemBase СвидетельствоОСмерти => GetProperty<EnumItemBase>();
    }
}
