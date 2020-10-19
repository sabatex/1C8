using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПереченьПособийСоциальногоСтрахования:V1C8COMObject
    {
        public ПереченьПособийСоциальногоСтрахования(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Нетрудоспособность => GetProperty<EnumItemBase>();
        public EnumItemBase БеременностьРоды => GetProperty<EnumItemBase>();
        public EnumItemBase ПриРожденииРебенка => GetProperty<EnumItemBase>();
        public EnumItemBase ПриПостановкеНаУчетВРанниеСрокиБеременности => GetProperty<EnumItemBase>();
        public EnumItemBase ВСвязиСоСмертью => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительныеВыходныеДниПоУходуЗаДетьмиИнвалидами => GetProperty<EnumItemBase>();
        public EnumItemBase НетрудоспособностьНесчастныйСлучай => GetProperty<EnumItemBase>();
        public EnumItemBase НетрудоспособностьПрофзаболевание => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительныйОтпускПослеНесчастныхСлучаев => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуЗаРебенком => GetProperty<EnumItemBase>();
        public EnumItemBase СтраховыеВзносыПоДопВыходнымПоУходуЗаДетьмиИнвалидами => GetProperty<EnumItemBase>();
    }
}
