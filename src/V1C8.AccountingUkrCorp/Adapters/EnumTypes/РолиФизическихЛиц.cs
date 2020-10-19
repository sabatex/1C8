using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РолиФизическихЛиц:EnumBase
    {
        public РолиФизическихЛиц(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Сотрудник => GetProperty<EnumItem>("Сотрудник");
        public EnumItem БывшийСотрудник => GetProperty<EnumItem>("БывшийСотрудник");
        public EnumItem Акционер => GetProperty<EnumItem>("Акционер");
        public EnumItem ПрочийПолучательДоходов => GetProperty<EnumItem>("ПрочийПолучательДоходов");
        public EnumItem РаздатчикЗарплаты => GetProperty<EnumItem>("РаздатчикЗарплаты");
        public EnumItem Кандидат => GetProperty<EnumItem>("Кандидат");
    }
}
