using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДанныхУчетаВремениСотрудников:EnumBase
    {
        public ВидыДанныхУчетаВремениСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДанныеОбщихГрафиков => GetProperty<EnumItem>("ДанныеОбщихГрафиков");
        public EnumItem ДанныеИндивидуальныхГрафиков => GetProperty<EnumItem>("ДанныеИндивидуальныхГрафиков");
        public EnumItem ДанныеТабельногоУчета => GetProperty<EnumItem>("ДанныеТабельногоУчета");
        public EnumItem ДанныеОперативногоУчета => GetProperty<EnumItem>("ДанныеОперативногоУчета");
        public EnumItem ДанныеВнутрисменныхНеявок => GetProperty<EnumItem>("ДанныеВнутрисменныхНеявок");
        public EnumItem ВытесняемоеПлановоеВремя => GetProperty<EnumItem>("ВытесняемоеПлановоеВремя");
        public EnumItem ДополнительноеВнутрисменноеВремя => GetProperty<EnumItem>("ДополнительноеВнутрисменноеВремя");
        public EnumItem СводныеДанные => GetProperty<EnumItem>("СводныеДанные");
    }
}
