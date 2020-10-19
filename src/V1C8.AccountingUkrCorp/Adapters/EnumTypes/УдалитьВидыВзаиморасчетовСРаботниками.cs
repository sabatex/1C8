using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьВидыВзаиморасчетовСРаботниками:EnumBase
    {
        public УдалитьВидыВзаиморасчетовСРаботниками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЗаработнаяПлата => GetProperty<EnumItem>("ЗаработнаяПлата");
        public EnumItem ЗаработнаяПлатаНеФОТ => GetProperty<EnumItem>("ЗаработнаяПлатаНеФОТ");
        public EnumItem Дивиденды => GetProperty<EnumItem>("Дивиденды");
        public EnumItem ДепонированнаяЗарплата => GetProperty<EnumItem>("ДепонированнаяЗарплата");
    }
}
