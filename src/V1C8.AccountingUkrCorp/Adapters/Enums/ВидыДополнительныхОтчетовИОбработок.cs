using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДополнительныхОтчетовИОбработок:V1C8COMObject
    {
        public ВидыДополнительныхОтчетовИОбработок(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДополнительнаяОбработка => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительныйОтчет => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаполнениеОбъекта => GetProperty<EnumItemBase>();
        public EnumItemBase Отчет => GetProperty<EnumItemBase>();
        public EnumItemBase ПечатнаяФорма => GetProperty<EnumItemBase>();
        public EnumItemBase СозданиеСвязанныхОбъектов => GetProperty<EnumItemBase>();
        public EnumItemBase ШаблонСообщения => GetProperty<EnumItemBase>();
    }
}
