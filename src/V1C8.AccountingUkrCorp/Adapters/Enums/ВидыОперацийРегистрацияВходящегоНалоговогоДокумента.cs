using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийРегистрацияВходящегоНалоговогоДокумента:V1C8COMObject
    {
        public ВидыОперацийРегистрацияВходящегоНалоговогоДокумента(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НалоговаяНакладная => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетКорректировкиВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетКорректировкиКорректировка => GetProperty<EnumItemBase>();
        public EnumItemBase РаботыОтНерезидентаПрошлогоПериода => GetProperty<EnumItemBase>();
        public EnumItemBase ПогашениеНалоговогоВекселя => GetProperty<EnumItemBase>();
        public EnumItemBase BeксeльПpoшлoгoПepиoдa => GetProperty<EnumItemBase>();
        public EnumItemBase ТаможенноеОформлениеТоваровКомитента => GetProperty<EnumItemBase>();
        public EnumItemBase ИсправлениеОшибки => GetProperty<EnumItemBase>();
        public EnumItemBase ВосстановлениеНалоговогоКредита => GetProperty<EnumItemBase>();
        public EnumItemBase ТоварныйЧек => GetProperty<EnumItemBase>();
    }
}
