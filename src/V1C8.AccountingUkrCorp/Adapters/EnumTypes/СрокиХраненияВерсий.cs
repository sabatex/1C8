using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СрокиХраненияВерсий:V1C8COMObject
    {
        public СрокиХраненияВерсий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаПоследнююНеделю => GetProperty<EnumItemBase>("ЗаПоследнююНеделю");
        public EnumItemBase ЗаПоследнийМесяц => GetProperty<EnumItemBase>("ЗаПоследнийМесяц");
        public EnumItemBase ЗаПоследниеТриМесяца => GetProperty<EnumItemBase>("ЗаПоследниеТриМесяца");
        public EnumItemBase ЗаПоследниеШестьМесяцев => GetProperty<EnumItemBase>("ЗаПоследниеШестьМесяцев");
        public EnumItemBase ЗаПоследнийГод => GetProperty<EnumItemBase>("ЗаПоследнийГод");
        public EnumItemBase Бессрочно => GetProperty<EnumItemBase>("Бессрочно");
    }
}
