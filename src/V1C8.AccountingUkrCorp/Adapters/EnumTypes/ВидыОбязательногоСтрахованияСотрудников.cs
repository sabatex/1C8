using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОбязательногоСтрахованияСотрудников:V1C8COMObject
    {
        public ВидыОбязательногоСтрахованияСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПФРПоСуммарномуТарифу => GetProperty<EnumItemBase>("ПФРПоСуммарномуТарифу");
        public EnumItemBase ФССНесчастныеСлучаи => GetProperty<EnumItemBase>("ФССНесчастныеСлучаи");
        public EnumItemBase ФСС => GetProperty<EnumItemBase>("ФСС");
        public EnumItemBase ФФОМС => GetProperty<EnumItemBase>("ФФОМС");
        public EnumItemBase ПФРЗаЗанятыхНаПодземныхИВредныхРаботах => GetProperty<EnumItemBase>("ПФРЗаЗанятыхНаПодземныхИВредныхРаботах");
        public EnumItemBase ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах => GetProperty<EnumItemBase>("ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах");
        public EnumItemBase ДоплатаКПенсииЛетчикам => GetProperty<EnumItemBase>("ДоплатаКПенсииЛетчикам");
        public EnumItemBase ДоплатаКПенсииШахтерам => GetProperty<EnumItemBase>("ДоплатаКПенсииШахтерам");
        public EnumItemBase ПФРСтраховая => GetProperty<EnumItemBase>("ПФРСтраховая");
        public EnumItemBase ПФРНакопительная => GetProperty<EnumItemBase>("ПФРНакопительная");
        public EnumItemBase ТФОМС => GetProperty<EnumItemBase>("ТФОМС");
        public EnumItemBase ПФРСПревышения => GetProperty<EnumItemBase>("ПФРСПревышения");
    }
}
