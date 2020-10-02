using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыМестВыплатыЗарплаты", Comment = "", Synonym = "Виды мест выплаты зарплаты")]
    public class ВидыМестВыплатыЗарплаты:EnumItem
    {
        public static readonly ВидыМестВыплатыЗарплаты Касса = new ВидыМестВыплатыЗарплаты{Name= "Касса",Synonim="Через кассу",Comment=""};
        public static readonly ВидыМестВыплатыЗарплаты ЗарплатныйПроект = new ВидыМестВыплатыЗарплаты{Name= "ЗарплатныйПроект",Synonim="Зачислением на карточку",Comment=""};
        public static readonly ВидыМестВыплатыЗарплаты Раздатчик = new ВидыМестВыплатыЗарплаты{Name= "Раздатчик",Synonim="Через раздатчика",Comment=""};
        public static readonly ВидыМестВыплатыЗарплаты БанковскийСчет = new ВидыМестВыплатыЗарплаты{Name= "БанковскийСчет",Synonim="Перечислением на счет в банке",Comment=""};
    }
}
