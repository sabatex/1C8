using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОстатковНДСПродажОжидаемый:V1C8COMObject
    {
        public ВидыОстатковНДСПродажОжидаемый(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПравильнаяРегистрация => GetProperty<EnumItemBase>();
        public EnumItemBase ЕщеНеВыписаны => GetProperty<EnumItemBase>();
    }
}
