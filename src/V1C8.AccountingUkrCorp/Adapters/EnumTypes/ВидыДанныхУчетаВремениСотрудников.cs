using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДанныхУчетаВремениСотрудников:V1C8COMObject
    {
        public ВидыДанныхУчетаВремениСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДанныеОбщихГрафиков => GetProperty<EnumItemBase>("ДанныеОбщихГрафиков");
        public EnumItemBase ДанныеИндивидуальныхГрафиков => GetProperty<EnumItemBase>("ДанныеИндивидуальныхГрафиков");
        public EnumItemBase ДанныеТабельногоУчета => GetProperty<EnumItemBase>("ДанныеТабельногоУчета");
        public EnumItemBase ДанныеОперативногоУчета => GetProperty<EnumItemBase>("ДанныеОперативногоУчета");
        public EnumItemBase ДанныеВнутрисменныхНеявок => GetProperty<EnumItemBase>("ДанныеВнутрисменныхНеявок");
        public EnumItemBase ВытесняемоеПлановоеВремя => GetProperty<EnumItemBase>("ВытесняемоеПлановоеВремя");
        public EnumItemBase ДополнительноеВнутрисменноеВремя => GetProperty<EnumItemBase>("ДополнительноеВнутрисменноеВремя");
        public EnumItemBase СводныеДанные => GetProperty<EnumItemBase>("СводныеДанные");
    }
}
