using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРегистрацияВходящегоНалоговогоДокумента:V1C8COMObject
    {
        public ВидыОперацийРегистрацияВходящегоНалоговогоДокумента(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НалоговаяНакладная => GetProperty<EnumItemBase>("НалоговаяНакладная");
        public EnumItemBase РасчетКорректировкиВозврат => GetProperty<EnumItemBase>("РасчетКорректировкиВозврат");
        public EnumItemBase РасчетКорректировкиКорректировка => GetProperty<EnumItemBase>("РасчетКорректировкиКорректировка");
        public EnumItemBase РаботыОтНерезидентаПрошлогоПериода => GetProperty<EnumItemBase>("РаботыОтНерезидентаПрошлогоПериода");
        public EnumItemBase ПогашениеНалоговогоВекселя => GetProperty<EnumItemBase>("ПогашениеНалоговогоВекселя");
        public EnumItemBase BeксeльПpoшлoгoПepиoдa => GetProperty<EnumItemBase>("BeксeльПpoшлoгoПepиoдa");
        public EnumItemBase ТаможенноеОформлениеТоваровКомитента => GetProperty<EnumItemBase>("ТаможенноеОформлениеТоваровКомитента");
        public EnumItemBase ИсправлениеОшибки => GetProperty<EnumItemBase>("ИсправлениеОшибки");
        public EnumItemBase ВосстановлениеНалоговогоКредита => GetProperty<EnumItemBase>("ВосстановлениеНалоговогоКредита");
        public EnumItemBase ТоварныйЧек => GetProperty<EnumItemBase>("ТоварныйЧек");
    }
}
