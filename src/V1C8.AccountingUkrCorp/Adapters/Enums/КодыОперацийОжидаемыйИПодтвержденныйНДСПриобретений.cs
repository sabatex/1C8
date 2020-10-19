using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений:V1C8COMObject
    {
        public КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОжидаемыйНДС => GetProperty<EnumItemBase>();
        public EnumItemBase ПодтвержденныйНДС => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкаПервичныйДокумент => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкаНалоговыйДокумент => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкаРегламентная => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат => GetProperty<EnumItemBase>();
        public EnumItemBase РегистрацияАвансов => GetProperty<EnumItemBase>();
        public EnumItemBase ОтменаРегистрацииАвансов => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкаНеправильноОформленныхНалоговыхДокументов => GetProperty<EnumItemBase>();
    }
}
