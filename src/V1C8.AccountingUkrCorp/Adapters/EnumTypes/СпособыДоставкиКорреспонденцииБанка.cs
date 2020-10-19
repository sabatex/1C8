using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыДоставкиКорреспонденцииБанка:EnumBase
    {
        public СпособыДоставкиКорреспонденцииБанка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеРассылать => GetProperty<EnumItem>("НеРассылать");
        public EnumItem Email => GetProperty<EnumItem>("Email");
        public EnumItem Почтой => GetProperty<EnumItem>("Почтой");
    }
}
