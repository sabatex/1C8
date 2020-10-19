using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УстарелоВыплаченностьЗарплаты:V1C8COMObject
    {
        public УстарелоВыплаченностьЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеВыплачено => GetProperty<EnumItemBase>();
        public EnumItemBase Выплачено => GetProperty<EnumItemBase>();
        public EnumItemBase Задепонировано => GetProperty<EnumItemBase>();
    }
}
