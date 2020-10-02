using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РезультатыВыполненияОбмена", Comment = "", Synonym = "Результаты выполнения обмена")]
    public class РезультатыВыполненияОбмена:EnumItem
    {
        public static readonly РезультатыВыполненияОбмена Выполнено = new РезультатыВыполненияОбмена{Name= "Выполнено",Synonim="Выполнено",Comment=""};
        public static readonly РезультатыВыполненияОбмена Отменено = new РезультатыВыполненияОбмена{Name= "Отменено",Synonim="Отменено",Comment=""};
        public static readonly РезультатыВыполненияОбмена Ошибка = new РезультатыВыполненияОбмена{Name= "Ошибка",Synonim="Ошибка",Comment=""};
        public static readonly РезультатыВыполненияОбмена Ошибка_ТранспортСообщения = new РезультатыВыполненияОбмена{Name= "Ошибка_ТранспортСообщения",Synonim="Ошибка транспорта сообщения",Comment=""};
        public static readonly РезультатыВыполненияОбмена Предупреждение_СообщениеОбменаБылоРанееПринято = new РезультатыВыполненияОбмена{Name= "Предупреждение_СообщениеОбменаБылоРанееПринято",Synonim="Сообщение обмена было ранее принято",Comment=""};
        public static readonly РезультатыВыполненияОбмена ВыполненоСПредупреждениями = new РезультатыВыполненияОбмена{Name= "ВыполненоСПредупреждениями",Synonim="Выполнено с предупреждениями",Comment=""};
    }
}
