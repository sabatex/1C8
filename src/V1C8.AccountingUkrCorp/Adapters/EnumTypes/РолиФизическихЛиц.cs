using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РолиФизическихЛиц:V1C8COMObject
    {
        public РолиФизическихЛиц(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Сотрудник => GetProperty<EnumItemBase>("Сотрудник");
        public EnumItemBase БывшийСотрудник => GetProperty<EnumItemBase>("БывшийСотрудник");
        public EnumItemBase Акционер => GetProperty<EnumItemBase>("Акционер");
        public EnumItemBase ПрочийПолучательДоходов => GetProperty<EnumItemBase>("ПрочийПолучательДоходов");
        public EnumItemBase РаздатчикЗарплаты => GetProperty<EnumItemBase>("РаздатчикЗарплаты");
        public EnumItemBase Кандидат => GetProperty<EnumItemBase>("Кандидат");
    }
}
