using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОбязательногоСтрахованияСотрудников:EnumBase
    {
        public ВидыОбязательногоСтрахованияСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПФРПоСуммарномуТарифу => GetProperty<EnumItem>("ПФРПоСуммарномуТарифу");
        public EnumItem ФССНесчастныеСлучаи => GetProperty<EnumItem>("ФССНесчастныеСлучаи");
        public EnumItem ФСС => GetProperty<EnumItem>("ФСС");
        public EnumItem ФФОМС => GetProperty<EnumItem>("ФФОМС");
        public EnumItem ПФРЗаЗанятыхНаПодземныхИВредныхРаботах => GetProperty<EnumItem>("ПФРЗаЗанятыхНаПодземныхИВредныхРаботах");
        public EnumItem ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах => GetProperty<EnumItem>("ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах");
        public EnumItem ДоплатаКПенсииЛетчикам => GetProperty<EnumItem>("ДоплатаКПенсииЛетчикам");
        public EnumItem ДоплатаКПенсииШахтерам => GetProperty<EnumItem>("ДоплатаКПенсииШахтерам");
        public EnumItem ПФРСтраховая => GetProperty<EnumItem>("ПФРСтраховая");
        public EnumItem ПФРНакопительная => GetProperty<EnumItem>("ПФРНакопительная");
        public EnumItem ТФОМС => GetProperty<EnumItem>("ТФОМС");
        public EnumItem ПФРСПревышения => GetProperty<EnumItem>("ПФРСПревышения");
    }
}
