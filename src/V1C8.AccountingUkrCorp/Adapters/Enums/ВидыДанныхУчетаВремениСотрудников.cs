using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДанныхУчетаВремениСотрудников:V1C8COMObject
    {
        public ВидыДанныхУчетаВремениСотрудников(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДанныеОбщихГрафиков => GetProperty<EnumItemBase>();
        public EnumItemBase ДанныеИндивидуальныхГрафиков => GetProperty<EnumItemBase>();
        public EnumItemBase ДанныеТабельногоУчета => GetProperty<EnumItemBase>();
        public EnumItemBase ДанныеОперативногоУчета => GetProperty<EnumItemBase>();
        public EnumItemBase ДанныеВнутрисменныхНеявок => GetProperty<EnumItemBase>();
        public EnumItemBase ВытесняемоеПлановоеВремя => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительноеВнутрисменноеВремя => GetProperty<EnumItemBase>();
        public EnumItemBase СводныеДанные => GetProperty<EnumItemBase>();
    }
}
