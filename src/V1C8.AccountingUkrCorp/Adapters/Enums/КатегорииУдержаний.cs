using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииУдержаний:V1C8COMObject
    {
        public КатегорииУдержаний(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПрофсоюзныеВзносы => GetProperty<EnumItemBase>();
        public EnumItemBase Алименты => GetProperty<EnumItemBase>();
        public EnumItemBase ИсполнительныйЛист => GetProperty<EnumItemBase>();
        public EnumItemBase ПочтовыйСбор => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
        public EnumItemBase ВознаграждениеПлатежногоАгента => GetProperty<EnumItemBase>();
        public EnumItemBase УдержаниеЗаНеотработанныеДниОтпуска => GetProperty<EnumItemBase>();
        public EnumItemBase ДСВ => GetProperty<EnumItemBase>();
        public EnumItemBase ДобровольныеВзносыВНПФ => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочееУдержаниеВПользуТретьихЛиц => GetProperty<EnumItemBase>();
        public EnumItemBase УдержаниеВСчетРасчетовПоПрочимОперациям => GetProperty<EnumItemBase>();
        public EnumItemBase ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска => GetProperty<EnumItemBase>();
        public EnumItemBase ОбязательстваПоУченическомуДоговору => GetProperty<EnumItemBase>();
    }
}
