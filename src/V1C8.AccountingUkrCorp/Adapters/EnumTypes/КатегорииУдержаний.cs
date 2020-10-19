using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииУдержаний:V1C8COMObject
    {
        public КатегорииУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПрофсоюзныеВзносы => GetProperty<EnumItemBase>("ПрофсоюзныеВзносы");
        public EnumItemBase Алименты => GetProperty<EnumItemBase>("Алименты");
        public EnumItemBase ИсполнительныйЛист => GetProperty<EnumItemBase>("ИсполнительныйЛист");
        public EnumItemBase ПочтовыйСбор => GetProperty<EnumItemBase>("ПочтовыйСбор");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
        public EnumItemBase ВознаграждениеПлатежногоАгента => GetProperty<EnumItemBase>("ВознаграждениеПлатежногоАгента");
        public EnumItemBase УдержаниеЗаНеотработанныеДниОтпуска => GetProperty<EnumItemBase>("УдержаниеЗаНеотработанныеДниОтпуска");
        public EnumItemBase ДСВ => GetProperty<EnumItemBase>("ДСВ");
        public EnumItemBase ДобровольныеВзносыВНПФ => GetProperty<EnumItemBase>("ДобровольныеВзносыВНПФ");
        public EnumItemBase ПрочееУдержаниеВПользуТретьихЛиц => GetProperty<EnumItemBase>("ПрочееУдержаниеВПользуТретьихЛиц");
        public EnumItemBase УдержаниеВСчетРасчетовПоПрочимОперациям => GetProperty<EnumItemBase>("УдержаниеВСчетРасчетовПоПрочимОперациям");
        public EnumItemBase ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска => GetProperty<EnumItemBase>("ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска");
        public EnumItemBase ОбязательстваПоУченическомуДоговору => GetProperty<EnumItemBase>("ОбязательстваПоУченическомуДоговору");
    }
}
