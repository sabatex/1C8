using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыДоставкиКорреспонденцииБанка:V1C8COMObject
    {
        public СпособыДоставкиКорреспонденцииБанка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеРассылать => GetProperty<EnumItemBase>("НеРассылать");
        public EnumItemBase Email => GetProperty<EnumItemBase>("Email");
        public EnumItemBase Почтой => GetProperty<EnumItemBase>("Почтой");
    }
}
