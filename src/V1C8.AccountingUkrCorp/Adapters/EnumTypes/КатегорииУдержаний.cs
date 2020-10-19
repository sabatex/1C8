using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииУдержаний:EnumBase
    {
        public КатегорииУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПрофсоюзныеВзносы => GetProperty<EnumItem>("ПрофсоюзныеВзносы");
        public EnumItem Алименты => GetProperty<EnumItem>("Алименты");
        public EnumItem ИсполнительныйЛист => GetProperty<EnumItem>("ИсполнительныйЛист");
        public EnumItem ПочтовыйСбор => GetProperty<EnumItem>("ПочтовыйСбор");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
        public EnumItem ВознаграждениеПлатежногоАгента => GetProperty<EnumItem>("ВознаграждениеПлатежногоАгента");
        public EnumItem УдержаниеЗаНеотработанныеДниОтпуска => GetProperty<EnumItem>("УдержаниеЗаНеотработанныеДниОтпуска");
        public EnumItem ДСВ => GetProperty<EnumItem>("ДСВ");
        public EnumItem ДобровольныеВзносыВНПФ => GetProperty<EnumItem>("ДобровольныеВзносыВНПФ");
        public EnumItem ПрочееУдержаниеВПользуТретьихЛиц => GetProperty<EnumItem>("ПрочееУдержаниеВПользуТретьихЛиц");
        public EnumItem УдержаниеВСчетРасчетовПоПрочимОперациям => GetProperty<EnumItem>("УдержаниеВСчетРасчетовПоПрочимОперациям");
        public EnumItem ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска => GetProperty<EnumItem>("ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска");
        public EnumItem ОбязательстваПоУченическомуДоговору => GetProperty<EnumItem>("ОбязательстваПоУченическомуДоговору");
    }
}
