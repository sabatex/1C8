using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияМиграцииПриложения", Comment = "", Synonym = "Состояния миграции приложения")]
    public class СостоянияМиграцииПриложения:EnumItem
    {
        public static readonly СостоянияМиграцииПриложения Выполняется = new СостоянияМиграцииПриложения{Name= "Выполняется",Synonim="Выполняется",Comment=""};
        public static readonly СостоянияМиграцииПриложения ЗавершенаСОшибкой = new СостоянияМиграцииПриложения{Name= "ЗавершенаСОшибкой",Synonim="Завершена с ошибкой",Comment=""};
        public static readonly СостоянияМиграцииПриложения ЗавершенаУспешно = new СостоянияМиграцииПриложения{Name= "ЗавершенаУспешно",Synonim="Завершена успешно",Comment=""};
        public static readonly СостоянияМиграцииПриложения ОжиданиеЗагрузки = new СостоянияМиграцииПриложения{Name= "ОжиданиеЗагрузки",Synonim="Ожидание загрузки",Comment=""};
        public static readonly СостоянияМиграцииПриложения ОжиданиеОбновления = new СостоянияМиграцииПриложения{Name= "ОжиданиеОбновления",Synonim="Ожидание обновления",Comment=""};
    }
}
