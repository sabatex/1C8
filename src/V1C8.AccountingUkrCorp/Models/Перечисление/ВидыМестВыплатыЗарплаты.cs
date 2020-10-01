using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыМестВыплатыЗарплаты", Comment = "", Synonym = "Виды мест выплаты зарплаты")]
    public enum ВидыМестВыплатыЗарплаты
    {
        [Description1C8(Name = "Касса", Comment = "", Synonym = "Через кассу")]
        Касса,
        [Description1C8(Name = "ЗарплатныйПроект", Comment = "", Synonym = "Зачислением на карточку")]
        ЗарплатныйПроект,
        [Description1C8(Name = "Раздатчик", Comment = "", Synonym = "Через раздатчика")]
        Раздатчик,
        [Description1C8(Name = "БанковскийСчет", Comment = "", Synonym = "Перечислением на счет в банке")]
        БанковскийСчет
    }
}
