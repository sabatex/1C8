using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж:V1C8COMObject
    {
        public КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОжидаемыйНДС => GetProperty<EnumItemBase>("ОжидаемыйНДС");
        public EnumItemBase ПодтвержденныйНДС => GetProperty<EnumItemBase>("ПодтвержденныйНДС");
        public EnumItemBase КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат => GetProperty<EnumItemBase>("КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат");
        public EnumItemBase РегистрацияАвансов => GetProperty<EnumItemBase>("РегистрацияАвансов");
        public EnumItemBase ОтменаРегистрацииАвансов => GetProperty<EnumItemBase>("ОтменаРегистрацииАвансов");
        public EnumItemBase КорректировкаНеправильноОформленныхНалоговыхДокументов => GetProperty<EnumItemBase>("КорректировкаНеправильноОформленныхНалоговыхДокументов");
        public EnumItemBase ПереводОФвСоставНепроизводственных => GetProperty<EnumItemBase>("ПереводОФвСоставНепроизводственных");
    }
}
