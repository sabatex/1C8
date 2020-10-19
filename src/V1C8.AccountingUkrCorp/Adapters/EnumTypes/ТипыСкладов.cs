using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыСкладов:EnumBase
    {
        public ТипыСкладов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОптовыйСклад => GetProperty<EnumItem>("ОптовыйСклад");
        public EnumItem РозничныйМагазин => GetProperty<EnumItem>("РозничныйМагазин");
        public EnumItem НеавтоматизированнаяТорговаяТочка => GetProperty<EnumItem>("НеавтоматизированнаяТорговаяТочка");
    }
}
