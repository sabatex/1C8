using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПодтверждающихДокументовОтпускаПоУходу:EnumBase
    {
        public ВидыПодтверждающихДокументовОтпускаПоУходу(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СвидетельствоОРождении => GetProperty<EnumItem>("СвидетельствоОРождении");
        public EnumItem РешениеОбУстановленииОпеки => GetProperty<EnumItem>("РешениеОбУстановленииОпеки");
        public EnumItem ИнойДокументПодтверждающийРождениеРебенка => GetProperty<EnumItem>("ИнойДокументПодтверждающийРождениеРебенка");
        public EnumItem СвидетельствоОСмерти => GetProperty<EnumItem>("СвидетельствоОСмерти");
    }
}
