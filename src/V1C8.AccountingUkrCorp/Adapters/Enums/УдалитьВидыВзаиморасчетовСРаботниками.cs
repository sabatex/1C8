using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьВидыВзаиморасчетовСРаботниками:V1C8COMObject
    {
        public УдалитьВидыВзаиморасчетовСРаботниками(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаработнаяПлата => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаработнаяПлатаНеФОТ => GetProperty<EnumItemBase>();
        public EnumItemBase Дивиденды => GetProperty<EnumItemBase>();
        public EnumItemBase ДепонированнаяЗарплата => GetProperty<EnumItemBase>();
    }
}
