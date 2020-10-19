using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДополнительныхОтчетовИОбработок:V1C8COMObject
    {
        public ВидыДополнительныхОтчетовИОбработок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДополнительнаяОбработка => GetProperty<EnumItemBase>("ДополнительнаяОбработка");
        public EnumItemBase ДополнительныйОтчет => GetProperty<EnumItemBase>("ДополнительныйОтчет");
        public EnumItemBase ЗаполнениеОбъекта => GetProperty<EnumItemBase>("ЗаполнениеОбъекта");
        public EnumItemBase Отчет => GetProperty<EnumItemBase>("Отчет");
        public EnumItemBase ПечатнаяФорма => GetProperty<EnumItemBase>("ПечатнаяФорма");
        public EnumItemBase СозданиеСвязанныхОбъектов => GetProperty<EnumItemBase>("СозданиеСвязанныхОбъектов");
        public EnumItemBase ШаблонСообщения => GetProperty<EnumItemBase>("ШаблонСообщения");
    }
}
