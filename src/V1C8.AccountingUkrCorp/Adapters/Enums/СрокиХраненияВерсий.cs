using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СрокиХраненияВерсий:V1C8COMObject
    {
        public СрокиХраненияВерсий(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаПоследнююНеделю => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаПоследнийМесяц => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаПоследниеТриМесяца => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаПоследниеШестьМесяцев => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаПоследнийГод => GetProperty<EnumItemBase>();
        public EnumItemBase Бессрочно => GetProperty<EnumItemBase>();
    }
}
