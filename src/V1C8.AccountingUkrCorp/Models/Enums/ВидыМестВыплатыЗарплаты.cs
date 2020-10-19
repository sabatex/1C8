using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("VydyMestVyplatyZarplaty")]
    [Description1C8(Name = "ВидыМестВыплатыЗарплаты", Comment = "", Synonym = "Виды мест выплаты зарплаты")]
    public class ВидыМестВыплатыЗарплаты:EnumItem
    {
        public static readonly ВидыМестВыплатыЗарплаты Касса = new ВидыМестВыплатыЗарплаты{Name= "Касса",Synonym="Через кассу",Comment=""};
        public static readonly ВидыМестВыплатыЗарплаты ЗарплатныйПроект = new ВидыМестВыплатыЗарплаты{Name= "ЗарплатныйПроект",Synonym="Зачислением на карточку",Comment=""};
        public static readonly ВидыМестВыплатыЗарплаты Раздатчик = new ВидыМестВыплатыЗарплаты{Name= "Раздатчик",Synonym="Через раздатчика",Comment=""};
        public static readonly ВидыМестВыплатыЗарплаты БанковскийСчет = new ВидыМестВыплатыЗарплаты{Name= "БанковскийСчет",Synonym="Перечислением на счет в банке",Comment=""};
    }
}
