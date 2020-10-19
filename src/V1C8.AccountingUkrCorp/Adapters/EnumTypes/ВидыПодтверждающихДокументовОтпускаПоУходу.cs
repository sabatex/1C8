using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПодтверждающихДокументовОтпускаПоУходу:V1C8COMObject
    {
        public ВидыПодтверждающихДокументовОтпускаПоУходу(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СвидетельствоОРождении => GetProperty<EnumItemBase>("СвидетельствоОРождении");
        public EnumItemBase РешениеОбУстановленииОпеки => GetProperty<EnumItemBase>("РешениеОбУстановленииОпеки");
        public EnumItemBase ИнойДокументПодтверждающийРождениеРебенка => GetProperty<EnumItemBase>("ИнойДокументПодтверждающийРождениеРебенка");
        public EnumItemBase СвидетельствоОСмерти => GetProperty<EnumItemBase>("СвидетельствоОСмерти");
    }
}
