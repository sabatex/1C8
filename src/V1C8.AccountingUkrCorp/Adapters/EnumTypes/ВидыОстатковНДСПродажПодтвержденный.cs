using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОстатковНДСПродажПодтвержденный:V1C8COMObject
    {
        public ВидыОстатковНДСПродажПодтвержденный(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеправильноЗарегистрированы => GetProperty<EnumItemBase>("НеправильноЗарегистрированы");
        public EnumItemBase ВыписаныЗаранее => GetProperty<EnumItemBase>("ВыписаныЗаранее");
    }
}
