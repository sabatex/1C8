using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыНалоговыхДеклараций:V1C8COMObject
    {
        public ВидыНалоговыхДеклараций(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДекларацияПоНалогуНаПрибыль2015 => GetProperty<EnumItemBase>();
        public EnumItemBase ДекларацияПоНДС => GetProperty<EnumItemBase>();
        public EnumItemBase Пенсионный => GetProperty<EnumItemBase>();
        public EnumItemBase Безработица => GetProperty<EnumItemBase>();
        public EnumItemBase НесчастныйСлучай => GetProperty<EnumItemBase>();
        public EnumItemBase УтратаТрудоспобности => GetProperty<EnumItemBase>();
        public EnumItemBase ЕдиныйНалог => GetProperty<EnumItemBase>();
        public EnumItemBase ОтчетПоТруду => GetProperty<EnumItemBase>();
        public EnumItemBase ОтчетОбИспользованииРабочегоВремени => GetProperty<EnumItemBase>();
        public EnumItemBase ЕСВ => GetProperty<EnumItemBase>();
        public EnumItemBase ДекларацияОПрибыли => GetProperty<EnumItemBase>();
        public EnumItemBase ДекларацияПоНалогуНаПрибыльНКУ => GetProperty<EnumItemBase>();
        public EnumItemBase ДекларацияПоАкцизномуНалогу => GetProperty<EnumItemBase>();
    }
}
