using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыМалоценныхАктивов:V1C8COMObject
    {
        public ВидыМалоценныхАктивов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МалоценныйБыстроизнашивающийсяПредмет => GetProperty<EnumItemBase>();
        public EnumItemBase МалоценныйНеоборотныйАктив => GetProperty<EnumItemBase>();
        public EnumItemBase БиблиотечныеФонды => GetProperty<EnumItemBase>();
    }
}
