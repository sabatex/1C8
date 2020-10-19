using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СрокиХраненияВерсий:EnumBase
    {
        public СрокиХраненияВерсий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЗаПоследнююНеделю => GetProperty<EnumItem>("ЗаПоследнююНеделю");
        public EnumItem ЗаПоследнийМесяц => GetProperty<EnumItem>("ЗаПоследнийМесяц");
        public EnumItem ЗаПоследниеТриМесяца => GetProperty<EnumItem>("ЗаПоследниеТриМесяца");
        public EnumItem ЗаПоследниеШестьМесяцев => GetProperty<EnumItem>("ЗаПоследниеШестьМесяцев");
        public EnumItem ЗаПоследнийГод => GetProperty<EnumItem>("ЗаПоследнийГод");
        public EnumItem Бессрочно => GetProperty<EnumItem>("Бессрочно");
    }
}
