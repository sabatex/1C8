using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаСреднегоЗаработкаДляОплатыПособия:EnumBase
    {
        public СпособыРасчетаСреднегоЗаработкаДляОплатыПособия(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СреднийЗаработок => GetProperty<EnumItem>("СреднийЗаработок");
        public EnumItem ИсходяИзТарифнойСтавки => GetProperty<EnumItem>("ИсходяИзТарифнойСтавки");
        public EnumItem ИсходяИзМРОТ => GetProperty<EnumItem>("ИсходяИзМРОТ");
    }
}
