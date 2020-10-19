using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений:V1C8COMObject
    {
        public КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОжидаемыйНДС => GetProperty<EnumItemBase>("ОжидаемыйНДС");
        public EnumItemBase ПодтвержденныйНДС => GetProperty<EnumItemBase>("ПодтвержденныйНДС");
        public EnumItemBase КорректировкаПервичныйДокумент => GetProperty<EnumItemBase>("КорректировкаПервичныйДокумент");
        public EnumItemBase КорректировкаНалоговыйДокумент => GetProperty<EnumItemBase>("КорректировкаНалоговыйДокумент");
        public EnumItemBase КорректировкаРегламентная => GetProperty<EnumItemBase>("КорректировкаРегламентная");
        public EnumItemBase КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат => GetProperty<EnumItemBase>("КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат");
        public EnumItemBase РегистрацияАвансов => GetProperty<EnumItemBase>("РегистрацияАвансов");
        public EnumItemBase ОтменаРегистрацииАвансов => GetProperty<EnumItemBase>("ОтменаРегистрацииАвансов");
        public EnumItemBase КорректировкаНеправильноОформленныхНалоговыхДокументов => GetProperty<EnumItemBase>("КорректировкаНеправильноОформленныхНалоговыхДокументов");
    }
}
