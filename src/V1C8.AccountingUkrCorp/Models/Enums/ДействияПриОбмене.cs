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
    [Table("DeistvyiaPryObmene")]
    [Description1C8(Name = "ДействияПриОбмене", Comment = "", Synonym = "Действия при обмене")]
    public class ДействияПриОбмене:EnumItem
    {
        public static readonly ДействияПриОбмене ЗагрузкаДанных = new ДействияПриОбмене{Name= "ЗагрузкаДанных",Synonym="Получение данных",Comment=""};
        public static readonly ДействияПриОбмене ВыгрузкаДанных = new ДействияПриОбмене{Name= "ВыгрузкаДанных",Synonym="Отправка данных",Comment=""};
    }
}
