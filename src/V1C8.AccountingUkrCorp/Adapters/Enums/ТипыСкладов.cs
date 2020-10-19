using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыСкладов:V1C8COMObject
    {
        public ТипыСкладов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОптовыйСклад => GetProperty<EnumItemBase>();
        public EnumItemBase РозничныйМагазин => GetProperty<EnumItemBase>();
        public EnumItemBase НеавтоматизированнаяТорговаяТочка => GetProperty<EnumItemBase>();
    }
}
