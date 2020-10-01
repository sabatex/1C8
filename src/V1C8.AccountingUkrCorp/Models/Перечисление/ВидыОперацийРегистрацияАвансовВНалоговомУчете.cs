using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРегистрацияАвансовВНалоговомУчете", Comment = "", Synonym = "Виды операций регистрация авансов в налоговом учете")]
    public enum ВидыОперацийРегистрацияАвансовВНалоговомУчете
    {
        [Description1C8(Name = "АвансОпределениеПараметровНУ", Comment = "", Synonym = "Аванс: определение параметров НУ")]
        АвансОпределениеПараметровНУ,
        [Description1C8(Name = "АвансВозвратОпределениеПараметровНУ", Comment = "", Synonym = "Аванс (возврат): определение параметров НУ")]
        АвансВозвратОпределениеПараметровНУ,
        [Description1C8(Name = "ОтгрузкаОтменаРегистрацииВНУ", Comment = "", Synonym = "Отгрузка: отмена регистрации в НУ")]
        ОтгрузкаОтменаРегистрацииВНУ,
        [Description1C8(Name = "ОтгрузкаВозвратОтменаРегистрацииВНУ", Comment = "", Synonym = "Отгрузка (возврат): отмена регистрации в НУ")]
        ОтгрузкаВозвратОтменаРегистрацииВНУ
    }
}
