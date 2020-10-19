using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УстарелоВыплаченностьЗарплаты:EnumBase
    {
        public УстарелоВыплаченностьЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеВыплачено => GetProperty<EnumItem>("НеВыплачено");
        public EnumItem Выплачено => GetProperty<EnumItem>("Выплачено");
        public EnumItem Задепонировано => GetProperty<EnumItem>("Задепонировано");
    }
}
