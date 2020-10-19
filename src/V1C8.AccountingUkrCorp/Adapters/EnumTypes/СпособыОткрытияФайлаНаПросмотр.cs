using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОткрытияФайлаНаПросмотр:EnumBase
    {
        public СпособыОткрытияФайлаНаПросмотр(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СтандартнымПриложением => GetProperty<EnumItem>("СтандартнымПриложением");
        public EnumItem ВоВстроенномРедакторе => GetProperty<EnumItem>("ВоВстроенномРедакторе");
    }
}
