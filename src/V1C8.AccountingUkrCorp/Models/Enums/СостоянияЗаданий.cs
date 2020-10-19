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
    [Table("SostoianyiaZadanyi")]
    [Description1C8(Name = "СостоянияЗаданий", Comment = "", Synonym = "Состояния заданий")]
    public class СостоянияЗаданий:EnumItem
    {
        public static readonly СостоянияЗаданий Запланировано = new СостоянияЗаданий{Name= "Запланировано",Synonym="Запланировано",Comment="Задание запланировано на выполнение"};
        public static readonly СостоянияЗаданий Выполняется = new СостоянияЗаданий{Name= "Выполняется",Synonym="Выполняется",Comment="Задание выполняется"};
        public static readonly СостоянияЗаданий Завершено = new СостоянияЗаданий{Name= "Завершено",Synonym="Завершено",Comment="Задание завершено"};
        public static readonly СостоянияЗаданий НеЗапланировано = new СостоянияЗаданий{Name= "НеЗапланировано",Synonym="Не запланировано",Comment="Задание не запланировано"};
        public static readonly СостоянияЗаданий ОшибкаВыполнения = new СостоянияЗаданий{Name= "ОшибкаВыполнения",Synonym="Ошибка выполнения",Comment="Ошибка при выполнении задания"};
        public static readonly СостоянияЗаданий НеАктивно = new СостоянияЗаданий{Name= "НеАктивно",Synonym="Не активно",Comment="Задание не активно"};
        public static readonly СостоянияЗаданий ОбработкаОшибкиПриАварийномЗавершении = new СостоянияЗаданий{Name= "ОбработкаОшибкиПриАварийномЗавершении",Synonym="Обработка ошибки при аварийном завершении",Comment=""};
    }
}
