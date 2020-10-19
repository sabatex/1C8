using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыСкладов:V1C8COMObject
    {
        public ТипыСкладов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОптовыйСклад => GetProperty<EnumItemBase>("ОптовыйСклад");
        public EnumItemBase РозничныйМагазин => GetProperty<EnumItemBase>("РозничныйМагазин");
        public EnumItemBase НеавтоматизированнаяТорговаяТочка => GetProperty<EnumItemBase>("НеавтоматизированнаяТорговаяТочка");
    }
}
