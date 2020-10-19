using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПереченьПособийСоциальногоСтрахования:V1C8COMObject
    {
        public ПереченьПособийСоциальногоСтрахования(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Нетрудоспособность => GetProperty<EnumItemBase>("Нетрудоспособность");
        public EnumItemBase БеременностьРоды => GetProperty<EnumItemBase>("БеременностьРоды");
        public EnumItemBase ПриРожденииРебенка => GetProperty<EnumItemBase>("ПриРожденииРебенка");
        public EnumItemBase ПриПостановкеНаУчетВРанниеСрокиБеременности => GetProperty<EnumItemBase>("ПриПостановкеНаУчетВРанниеСрокиБеременности");
        public EnumItemBase ВСвязиСоСмертью => GetProperty<EnumItemBase>("ВСвязиСоСмертью");
        public EnumItemBase ДополнительныеВыходныеДниПоУходуЗаДетьмиИнвалидами => GetProperty<EnumItemBase>("ДополнительныеВыходныеДниПоУходуЗаДетьмиИнвалидами");
        public EnumItemBase НетрудоспособностьНесчастныйСлучай => GetProperty<EnumItemBase>("НетрудоспособностьНесчастныйСлучай");
        public EnumItemBase НетрудоспособностьПрофзаболевание => GetProperty<EnumItemBase>("НетрудоспособностьПрофзаболевание");
        public EnumItemBase ДополнительныйОтпускПослеНесчастныхСлучаев => GetProperty<EnumItemBase>("ДополнительныйОтпускПослеНесчастныхСлучаев");
        public EnumItemBase ПоУходуЗаРебенком => GetProperty<EnumItemBase>("ПоУходуЗаРебенком");
        public EnumItemBase СтраховыеВзносыПоДопВыходнымПоУходуЗаДетьмиИнвалидами => GetProperty<EnumItemBase>("СтраховыеВзносыПоДопВыходнымПоУходуЗаДетьмиИнвалидами");
    }
}
