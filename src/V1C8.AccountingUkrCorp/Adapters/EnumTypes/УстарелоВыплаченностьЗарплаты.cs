using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УстарелоВыплаченностьЗарплаты:V1C8COMObject
    {
        public УстарелоВыплаченностьЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеВыплачено => GetProperty<EnumItemBase>("НеВыплачено");
        public EnumItemBase Выплачено => GetProperty<EnumItemBase>("Выплачено");
        public EnumItemBase Задепонировано => GetProperty<EnumItemBase>("Задепонировано");
    }
}
