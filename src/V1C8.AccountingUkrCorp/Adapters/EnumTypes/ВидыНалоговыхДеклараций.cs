using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНалоговыхДеклараций:V1C8COMObject
    {
        public ВидыНалоговыхДеклараций(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДекларацияПоНалогуНаПрибыль2015 => GetProperty<EnumItemBase>("ДекларацияПоНалогуНаПрибыль2015");
        public EnumItemBase ДекларацияПоНДС => GetProperty<EnumItemBase>("ДекларацияПоНДС");
        public EnumItemBase Пенсионный => GetProperty<EnumItemBase>("Пенсионный");
        public EnumItemBase Безработица => GetProperty<EnumItemBase>("Безработица");
        public EnumItemBase НесчастныйСлучай => GetProperty<EnumItemBase>("НесчастныйСлучай");
        public EnumItemBase УтратаТрудоспобности => GetProperty<EnumItemBase>("УтратаТрудоспобности");
        public EnumItemBase ЕдиныйНалог => GetProperty<EnumItemBase>("ЕдиныйНалог");
        public EnumItemBase ОтчетПоТруду => GetProperty<EnumItemBase>("ОтчетПоТруду");
        public EnumItemBase ОтчетОбИспользованииРабочегоВремени => GetProperty<EnumItemBase>("ОтчетОбИспользованииРабочегоВремени");
        public EnumItemBase ЕСВ => GetProperty<EnumItemBase>("ЕСВ");
        public EnumItemBase ДекларацияОПрибыли => GetProperty<EnumItemBase>("ДекларацияОПрибыли");
        public EnumItemBase ДекларацияПоНалогуНаПрибыльНКУ => GetProperty<EnumItemBase>("ДекларацияПоНалогуНаПрибыльНКУ");
        public EnumItemBase ДекларацияПоАкцизномуНалогу => GetProperty<EnumItemBase>("ДекларацияПоАкцизномуНалогу");
    }
}
