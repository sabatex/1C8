using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаСреднегоЗаработкаДляОплатыПособия:V1C8COMObject
    {
        public СпособыРасчетаСреднегоЗаработкаДляОплатыПособия(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СреднийЗаработок => GetProperty<EnumItemBase>("СреднийЗаработок");
        public EnumItemBase ИсходяИзТарифнойСтавки => GetProperty<EnumItemBase>("ИсходяИзТарифнойСтавки");
        public EnumItemBase ИсходяИзМРОТ => GetProperty<EnumItemBase>("ИсходяИзМРОТ");
    }
}
