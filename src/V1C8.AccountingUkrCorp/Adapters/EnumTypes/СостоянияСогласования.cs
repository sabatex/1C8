using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияСогласования:EnumBase
    {
        public СостоянияСогласования(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Отклонено => GetProperty<EnumItem>("Отклонено");
        public EnumItem Рассматривается => GetProperty<EnumItem>("Рассматривается");
        public EnumItem Согласовано => GetProperty<EnumItem>("Согласовано");
    }
}
