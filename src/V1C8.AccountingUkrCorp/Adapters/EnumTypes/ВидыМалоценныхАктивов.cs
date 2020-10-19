using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыМалоценныхАктивов:V1C8COMObject
    {
        public ВидыМалоценныхАктивов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МалоценныйБыстроизнашивающийсяПредмет => GetProperty<EnumItemBase>("МалоценныйБыстроизнашивающийсяПредмет");
        public EnumItemBase МалоценныйНеоборотныйАктив => GetProperty<EnumItemBase>("МалоценныйНеоборотныйАктив");
        public EnumItemBase БиблиотечныеФонды => GetProperty<EnumItemBase>("БиблиотечныеФонды");
    }
}
