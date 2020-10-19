using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОткрытияФайлаНаПросмотр:V1C8COMObject
    {
        public СпособыОткрытияФайлаНаПросмотр(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СтандартнымПриложением => GetProperty<EnumItemBase>("СтандартнымПриложением");
        public EnumItemBase ВоВстроенномРедакторе => GetProperty<EnumItemBase>("ВоВстроенномРедакторе");
    }
}
