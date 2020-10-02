using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьДействиеПриОбмене", Comment = "", Synonym = "(не используется) Действие при обмене")]
    public class УдалитьДействиеПриОбмене:EnumItem
    {
        public static readonly УдалитьДействиеПриОбмене ЗагрузкаДанных = new УдалитьДействиеПриОбмене{Name= "ЗагрузкаДанных",Synonym="Загрузка данных",Comment=""};
        public static readonly УдалитьДействиеПриОбмене ОтложенныеДвижения = new УдалитьДействиеПриОбмене{Name= "ОтложенныеДвижения",Synonym="Отложенные движения",Comment=""};
        public static readonly УдалитьДействиеПриОбмене ВыгрузкаДанных = new УдалитьДействиеПриОбмене{Name= "ВыгрузкаДанных",Synonym="Выгрузка данных",Comment=""};
    }
}
