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
    [Table("SostoianyiaMyhratsyyPrylozhenyia")]
    [Description1C8(Name = "СостоянияМиграцииПриложения", Comment = "", Synonym = "Состояния миграции приложения")]
    public class СостоянияМиграцииПриложения:EnumItem
    {
        public static readonly СостоянияМиграцииПриложения Выполняется = new СостоянияМиграцииПриложения{Name= "Выполняется",Synonym="Выполняется",Comment=""};
        public static readonly СостоянияМиграцииПриложения ЗавершенаСОшибкой = new СостоянияМиграцииПриложения{Name= "ЗавершенаСОшибкой",Synonym="Завершена с ошибкой",Comment=""};
        public static readonly СостоянияМиграцииПриложения ЗавершенаУспешно = new СостоянияМиграцииПриложения{Name= "ЗавершенаУспешно",Synonym="Завершена успешно",Comment=""};
        public static readonly СостоянияМиграцииПриложения ОжиданиеЗагрузки = new СостоянияМиграцииПриложения{Name= "ОжиданиеЗагрузки",Synonym="Ожидание загрузки",Comment=""};
        public static readonly СостоянияМиграцииПриложения ОжиданиеОбновления = new СостоянияМиграцииПриложения{Name= "ОжиданиеОбновления",Synonym="Ожидание обновления",Comment=""};
    }
}
