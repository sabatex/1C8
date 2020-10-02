using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыВыполненияОбмена", Comment = "", Synonym = "Результаты выполнения обмена")]
    public class РезультатыВыполненияОбмена:EnumItem
    {
        public static readonly РезультатыВыполненияОбмена Выполнено = new РезультатыВыполненияОбмена{Name= "Выполнено",Synonym="Выполнено",Comment=""};
        public static readonly РезультатыВыполненияОбмена Отменено = new РезультатыВыполненияОбмена{Name= "Отменено",Synonym="Отменено",Comment=""};
        public static readonly РезультатыВыполненияОбмена Ошибка = new РезультатыВыполненияОбмена{Name= "Ошибка",Synonym="Ошибка",Comment=""};
        public static readonly РезультатыВыполненияОбмена Ошибка_ТранспортСообщения = new РезультатыВыполненияОбмена{Name= "Ошибка_ТранспортСообщения",Synonym="Ошибка транспорта сообщения",Comment=""};
        public static readonly РезультатыВыполненияОбмена Предупреждение_СообщениеОбменаБылоРанееПринято = new РезультатыВыполненияОбмена{Name= "Предупреждение_СообщениеОбменаБылоРанееПринято",Synonym="Сообщение обмена было ранее принято",Comment=""};
        public static readonly РезультатыВыполненияОбмена ВыполненоСПредупреждениями = new РезультатыВыполненияОбмена{Name= "ВыполненоСПредупреждениями",Synonym="Выполнено с предупреждениями",Comment=""};
    }
}
