using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияСогласования:V1C8COMObject
    {
        public СостоянияСогласования(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Отклонено => GetProperty<EnumItemBase>();
        public EnumItemBase Рассматривается => GetProperty<EnumItemBase>();
        public EnumItemBase Согласовано => GetProperty<EnumItemBase>();
    }
}
