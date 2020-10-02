using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаСреднегоЗаработкаДляОплатыПособия", Comment = "", Synonym = "Способы расчета среднего заработка для оплаты пособия")]
    public class СпособыРасчетаСреднегоЗаработкаДляОплатыПособия:EnumItem
    {
        public static readonly СпособыРасчетаСреднегоЗаработкаДляОплатыПособия СреднийЗаработок = new СпособыРасчетаСреднегоЗаработкаДляОплатыПособия{Name= "СреднийЗаработок",Synonim="Средний заработок",Comment=""};
        public static readonly СпособыРасчетаСреднегоЗаработкаДляОплатыПособия ИсходяИзТарифнойСтавки = new СпособыРасчетаСреднегоЗаработкаДляОплатыПособия{Name= "ИсходяИзТарифнойСтавки",Synonim="Исходя из тарифной ставки",Comment=""};
        public static readonly СпособыРасчетаСреднегоЗаработкаДляОплатыПособия ИсходяИзМРОТ = new СпособыРасчетаСреднегоЗаработкаДляОплатыПособия{Name= "ИсходяИзМРОТ",Synonim="Исходя из МРОТ",Comment=""};
    }
}
