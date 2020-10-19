using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыНачисленияУдержанияВыплаты:V1C8COMObject
    {
        public ГруппыНачисленияУдержанияВыплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НачальноеСальдоПериода => GetProperty<EnumItemBase>("НачальноеСальдоПериода");
        public EnumItemBase НачальноеСальдо => GetProperty<EnumItemBase>("НачальноеСальдо");
        public EnumItemBase Начислено => GetProperty<EnumItemBase>("Начислено");
        public EnumItemBase Удержано => GetProperty<EnumItemBase>("Удержано");
        public EnumItemBase Выплачено => GetProperty<EnumItemBase>("Выплачено");
        public EnumItemBase КонечноеСальдо => GetProperty<EnumItemBase>("КонечноеСальдо");
        public EnumItemBase КонечноеСальдоПериода => GetProperty<EnumItemBase>("КонечноеСальдоПериода");
        public EnumItemBase Справочно => GetProperty<EnumItemBase>("Справочно");
        public EnumItemBase Льготы => GetProperty<EnumItemBase>("Льготы");
    }
}
