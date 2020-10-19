using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыДоставкиКорреспонденцииБанка:V1C8COMObject
    {
        public СпособыДоставкиКорреспонденцииБанка(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеРассылать => GetProperty<EnumItemBase>();
        public EnumItemBase Email => GetProperty<EnumItemBase>();
        public EnumItemBase Почтой => GetProperty<EnumItemBase>();
    }
}
