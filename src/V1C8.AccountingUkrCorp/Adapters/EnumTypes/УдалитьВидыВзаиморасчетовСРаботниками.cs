using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьВидыВзаиморасчетовСРаботниками:V1C8COMObject
    {
        public УдалитьВидыВзаиморасчетовСРаботниками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаработнаяПлата => GetProperty<EnumItemBase>("ЗаработнаяПлата");
        public EnumItemBase ЗаработнаяПлатаНеФОТ => GetProperty<EnumItemBase>("ЗаработнаяПлатаНеФОТ");
        public EnumItemBase Дивиденды => GetProperty<EnumItemBase>("Дивиденды");
        public EnumItemBase ДепонированнаяЗарплата => GetProperty<EnumItemBase>("ДепонированнаяЗарплата");
    }
}
