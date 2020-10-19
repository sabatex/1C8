using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РолиФизическихЛиц:V1C8COMObject
    {
        public РолиФизическихЛиц(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Сотрудник => GetProperty<EnumItemBase>();
        public EnumItemBase БывшийСотрудник => GetProperty<EnumItemBase>();
        public EnumItemBase Акционер => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочийПолучательДоходов => GetProperty<EnumItemBase>();
        public EnumItemBase РаздатчикЗарплаты => GetProperty<EnumItemBase>();
        public EnumItemBase Кандидат => GetProperty<EnumItemBase>();
    }
}
