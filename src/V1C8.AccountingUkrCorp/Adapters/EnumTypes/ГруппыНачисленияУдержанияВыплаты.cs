using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыНачисленияУдержанияВыплаты:EnumBase
    {
        public ГруппыНачисленияУдержанияВыплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НачальноеСальдоПериода => GetProperty<EnumItem>("НачальноеСальдоПериода");
        public EnumItem НачальноеСальдо => GetProperty<EnumItem>("НачальноеСальдо");
        public EnumItem Начислено => GetProperty<EnumItem>("Начислено");
        public EnumItem Удержано => GetProperty<EnumItem>("Удержано");
        public EnumItem Выплачено => GetProperty<EnumItem>("Выплачено");
        public EnumItem КонечноеСальдо => GetProperty<EnumItem>("КонечноеСальдо");
        public EnumItem КонечноеСальдоПериода => GetProperty<EnumItem>("КонечноеСальдоПериода");
        public EnumItem Справочно => GetProperty<EnumItem>("Справочно");
        public EnumItem Льготы => GetProperty<EnumItem>("Льготы");
    }
}
