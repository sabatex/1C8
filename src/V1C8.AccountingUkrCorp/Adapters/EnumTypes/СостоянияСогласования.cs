using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияСогласования:V1C8COMObject
    {
        public СостоянияСогласования(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Отклонено => GetProperty<EnumItemBase>("Отклонено");
        public EnumItemBase Рассматривается => GetProperty<EnumItemBase>("Рассматривается");
        public EnumItemBase Согласовано => GetProperty<EnumItemBase>("Согласовано");
    }
}
