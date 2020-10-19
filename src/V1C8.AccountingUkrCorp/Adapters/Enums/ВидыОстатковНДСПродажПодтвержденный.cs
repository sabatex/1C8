using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОстатковНДСПродажПодтвержденный:V1C8COMObject
    {
        public ВидыОстатковНДСПродажПодтвержденный(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеправильноЗарегистрированы => GetProperty<EnumItemBase>();
        public EnumItemBase ВыписаныЗаранее => GetProperty<EnumItemBase>();
    }
}
