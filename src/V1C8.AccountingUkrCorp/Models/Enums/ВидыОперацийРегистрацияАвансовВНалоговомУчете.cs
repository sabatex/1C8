using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРегистрацияАвансовВНалоговомУчете", Comment = "", Synonym = "Виды операций регистрация авансов в налоговом учете")]
    public class ВидыОперацийРегистрацияАвансовВНалоговомУчете:EnumItem
    {
        public static readonly ВидыОперацийРегистрацияАвансовВНалоговомУчете АвансОпределениеПараметровНУ = new ВидыОперацийРегистрацияАвансовВНалоговомУчете{Name= "АвансОпределениеПараметровНУ",Synonym="Аванс: определение параметров НУ",Comment=""};
        public static readonly ВидыОперацийРегистрацияАвансовВНалоговомУчете АвансВозвратОпределениеПараметровНУ = new ВидыОперацийРегистрацияАвансовВНалоговомУчете{Name= "АвансВозвратОпределениеПараметровНУ",Synonym="Аванс (возврат): определение параметров НУ",Comment=""};
        public static readonly ВидыОперацийРегистрацияАвансовВНалоговомУчете ОтгрузкаОтменаРегистрацииВНУ = new ВидыОперацийРегистрацияАвансовВНалоговомУчете{Name= "ОтгрузкаОтменаРегистрацииВНУ",Synonym="Отгрузка: отмена регистрации в НУ",Comment=""};
        public static readonly ВидыОперацийРегистрацияАвансовВНалоговомУчете ОтгрузкаВозвратОтменаРегистрацииВНУ = new ВидыОперацийРегистрацияАвансовВНалоговомУчете{Name= "ОтгрузкаВозвратОтменаРегистрацииВНУ",Synonym="Отгрузка (возврат): отмена регистрации в НУ",Comment=""};
    }
}
