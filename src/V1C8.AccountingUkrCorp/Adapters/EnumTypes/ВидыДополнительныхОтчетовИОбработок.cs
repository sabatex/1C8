using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДополнительныхОтчетовИОбработок:EnumBase
    {
        public ВидыДополнительныхОтчетовИОбработок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДополнительнаяОбработка => GetProperty<EnumItem>("ДополнительнаяОбработка");
        public EnumItem ДополнительныйОтчет => GetProperty<EnumItem>("ДополнительныйОтчет");
        public EnumItem ЗаполнениеОбъекта => GetProperty<EnumItem>("ЗаполнениеОбъекта");
        public EnumItem Отчет => GetProperty<EnumItem>("Отчет");
        public EnumItem ПечатнаяФорма => GetProperty<EnumItem>("ПечатнаяФорма");
        public EnumItem СозданиеСвязанныхОбъектов => GetProperty<EnumItem>("СозданиеСвязанныхОбъектов");
        public EnumItem ШаблонСообщения => GetProperty<EnumItem>("ШаблонСообщения");
    }
}
