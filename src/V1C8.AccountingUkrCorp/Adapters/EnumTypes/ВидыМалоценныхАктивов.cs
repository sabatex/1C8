using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыМалоценныхАктивов:EnumBase
    {
        public ВидыМалоценныхАктивов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem МалоценныйБыстроизнашивающийсяПредмет => GetProperty<EnumItem>("МалоценныйБыстроизнашивающийсяПредмет");
        public EnumItem МалоценныйНеоборотныйАктив => GetProperty<EnumItem>("МалоценныйНеоборотныйАктив");
        public EnumItem БиблиотечныеФонды => GetProperty<EnumItem>("БиблиотечныеФонды");
    }
}
