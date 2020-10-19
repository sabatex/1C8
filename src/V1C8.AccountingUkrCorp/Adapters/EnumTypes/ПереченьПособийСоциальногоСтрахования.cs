using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПереченьПособийСоциальногоСтрахования:EnumBase
    {
        public ПереченьПособийСоциальногоСтрахования(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Нетрудоспособность => GetProperty<EnumItem>("Нетрудоспособность");
        public EnumItem БеременностьРоды => GetProperty<EnumItem>("БеременностьРоды");
        public EnumItem ПриРожденииРебенка => GetProperty<EnumItem>("ПриРожденииРебенка");
        public EnumItem ПриПостановкеНаУчетВРанниеСрокиБеременности => GetProperty<EnumItem>("ПриПостановкеНаУчетВРанниеСрокиБеременности");
        public EnumItem ВСвязиСоСмертью => GetProperty<EnumItem>("ВСвязиСоСмертью");
        public EnumItem ДополнительныеВыходныеДниПоУходуЗаДетьмиИнвалидами => GetProperty<EnumItem>("ДополнительныеВыходныеДниПоУходуЗаДетьмиИнвалидами");
        public EnumItem НетрудоспособностьНесчастныйСлучай => GetProperty<EnumItem>("НетрудоспособностьНесчастныйСлучай");
        public EnumItem НетрудоспособностьПрофзаболевание => GetProperty<EnumItem>("НетрудоспособностьПрофзаболевание");
        public EnumItem ДополнительныйОтпускПослеНесчастныхСлучаев => GetProperty<EnumItem>("ДополнительныйОтпускПослеНесчастныхСлучаев");
        public EnumItem ПоУходуЗаРебенком => GetProperty<EnumItem>("ПоУходуЗаРебенком");
        public EnumItem СтраховыеВзносыПоДопВыходнымПоУходуЗаДетьмиИнвалидами => GetProperty<EnumItem>("СтраховыеВзносыПоДопВыходнымПоУходуЗаДетьмиИнвалидами");
    }
}
