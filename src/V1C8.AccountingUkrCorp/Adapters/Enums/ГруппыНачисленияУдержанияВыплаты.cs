using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ГруппыНачисленияУдержанияВыплаты:V1C8COMObject
    {
        public ГруппыНачисленияУдержанияВыплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НачальноеСальдоПериода => GetProperty<EnumItemBase>();
        public EnumItemBase НачальноеСальдо => GetProperty<EnumItemBase>();
        public EnumItemBase Начислено => GetProperty<EnumItemBase>();
        public EnumItemBase Удержано => GetProperty<EnumItemBase>();
        public EnumItemBase Выплачено => GetProperty<EnumItemBase>();
        public EnumItemBase КонечноеСальдо => GetProperty<EnumItemBase>();
        public EnumItemBase КонечноеСальдоПериода => GetProperty<EnumItemBase>();
        public EnumItemBase Справочно => GetProperty<EnumItemBase>();
        public EnumItemBase Льготы => GetProperty<EnumItemBase>();
    }
}
