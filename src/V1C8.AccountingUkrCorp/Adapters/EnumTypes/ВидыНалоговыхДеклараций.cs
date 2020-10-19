using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНалоговыхДеклараций:EnumBase
    {
        public ВидыНалоговыхДеклараций(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДекларацияПоНалогуНаПрибыль2015 => GetProperty<EnumItem>("ДекларацияПоНалогуНаПрибыль2015");
        public EnumItem ДекларацияПоНДС => GetProperty<EnumItem>("ДекларацияПоНДС");
        public EnumItem Пенсионный => GetProperty<EnumItem>("Пенсионный");
        public EnumItem Безработица => GetProperty<EnumItem>("Безработица");
        public EnumItem НесчастныйСлучай => GetProperty<EnumItem>("НесчастныйСлучай");
        public EnumItem УтратаТрудоспобности => GetProperty<EnumItem>("УтратаТрудоспобности");
        public EnumItem ЕдиныйНалог => GetProperty<EnumItem>("ЕдиныйНалог");
        public EnumItem ОтчетПоТруду => GetProperty<EnumItem>("ОтчетПоТруду");
        public EnumItem ОтчетОбИспользованииРабочегоВремени => GetProperty<EnumItem>("ОтчетОбИспользованииРабочегоВремени");
        public EnumItem ЕСВ => GetProperty<EnumItem>("ЕСВ");
        public EnumItem ДекларацияОПрибыли => GetProperty<EnumItem>("ДекларацияОПрибыли");
        public EnumItem ДекларацияПоНалогуНаПрибыльНКУ => GetProperty<EnumItem>("ДекларацияПоНалогуНаПрибыльНКУ");
        public EnumItem ДекларацияПоАкцизномуНалогу => GetProperty<EnumItem>("ДекларацияПоАкцизномуНалогу");
    }
}
