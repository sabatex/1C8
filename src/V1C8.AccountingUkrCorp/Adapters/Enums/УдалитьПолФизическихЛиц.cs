using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьПолФизическихЛиц:V1C8COMObject
    {
        public УдалитьПолФизическихЛиц(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Мужской => GetProperty<EnumItemBase>();
        public EnumItemBase Женский => GetProperty<EnumItemBase>();
    }
}
