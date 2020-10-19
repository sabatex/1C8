using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений:EnumBase
    {
        public КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОжидаемыйНДС => GetProperty<EnumItem>("ОжидаемыйНДС");
        public EnumItem ПодтвержденныйНДС => GetProperty<EnumItem>("ПодтвержденныйНДС");
        public EnumItem КорректировкаПервичныйДокумент => GetProperty<EnumItem>("КорректировкаПервичныйДокумент");
        public EnumItem КорректировкаНалоговыйДокумент => GetProperty<EnumItem>("КорректировкаНалоговыйДокумент");
        public EnumItem КорректировкаРегламентная => GetProperty<EnumItem>("КорректировкаРегламентная");
        public EnumItem КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат => GetProperty<EnumItem>("КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат");
        public EnumItem РегистрацияАвансов => GetProperty<EnumItem>("РегистрацияАвансов");
        public EnumItem ОтменаРегистрацииАвансов => GetProperty<EnumItem>("ОтменаРегистрацииАвансов");
        public EnumItem КорректировкаНеправильноОформленныхНалоговыхДокументов => GetProperty<EnumItem>("КорректировкаНеправильноОформленныхНалоговыхДокументов");
    }
}
