using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРегистрацияВходящегоНалоговогоДокумента:EnumBase
    {
        public ВидыОперацийРегистрацияВходящегоНалоговогоДокумента(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НалоговаяНакладная => GetProperty<EnumItem>("НалоговаяНакладная");
        public EnumItem РасчетКорректировкиВозврат => GetProperty<EnumItem>("РасчетКорректировкиВозврат");
        public EnumItem РасчетКорректировкиКорректировка => GetProperty<EnumItem>("РасчетКорректировкиКорректировка");
        public EnumItem РаботыОтНерезидентаПрошлогоПериода => GetProperty<EnumItem>("РаботыОтНерезидентаПрошлогоПериода");
        public EnumItem ПогашениеНалоговогоВекселя => GetProperty<EnumItem>("ПогашениеНалоговогоВекселя");
        public EnumItem BeксeльПpoшлoгoПepиoдa => GetProperty<EnumItem>("BeксeльПpoшлoгoПepиoдa");
        public EnumItem ТаможенноеОформлениеТоваровКомитента => GetProperty<EnumItem>("ТаможенноеОформлениеТоваровКомитента");
        public EnumItem ИсправлениеОшибки => GetProperty<EnumItem>("ИсправлениеОшибки");
        public EnumItem ВосстановлениеНалоговогоКредита => GetProperty<EnumItem>("ВосстановлениеНалоговогоКредита");
        public EnumItem ТоварныйЧек => GetProperty<EnumItem>("ТоварныйЧек");
    }
}
