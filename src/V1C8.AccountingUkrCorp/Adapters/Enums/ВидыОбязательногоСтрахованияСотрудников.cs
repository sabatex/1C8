using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОбязательногоСтрахованияСотрудников:V1C8COMObject
    {
        public ВидыОбязательногоСтрахованияСотрудников(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПФРПоСуммарномуТарифу => GetProperty<EnumItemBase>();
        public EnumItemBase ФССНесчастныеСлучаи => GetProperty<EnumItemBase>();
        public EnumItemBase ФСС => GetProperty<EnumItemBase>();
        public EnumItemBase ФФОМС => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРЗаЗанятыхНаПодземныхИВредныхРаботах => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаКПенсииЛетчикам => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаКПенсииШахтерам => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРСтраховая => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРНакопительная => GetProperty<EnumItemBase>();
        public EnumItemBase ТФОМС => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРСПревышения => GetProperty<EnumItemBase>();
    }
}
