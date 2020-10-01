using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДокументовМежрасчетныхНачислений", Comment = "", Synonym = "Виды документов межрасчетных начислений")]
    public enum ВидыДокументовМежрасчетныхНачислений
    {
        [Description1C8(Name = "БольничныйЛист", Comment = "", Synonym = "Больничный лист")]
        БольничныйЛист,
        [Description1C8(Name = "ВозвратНДФЛ", Comment = "", Synonym = "ѳ(не украинский) Возврат НДФЛ")]
        ВозвратНДФЛ,
        [Description1C8(Name = "ЕдиновременноеПособиеЗаСчетФСС", Comment = "", Synonym = "Единовременное пособие за счет ФСС")]
        ЕдиновременноеПособиеЗаСчетФСС,
        [Description1C8(Name = "Командировка", Comment = "", Synonym = "Командировка")]
        Командировка,
        [Description1C8(Name = "КомпенсацияЗаЗадержкуЗарплаты", Comment = "", Synonym = "Компенсация за задержку выплаты заработной платы")]
        КомпенсацияЗаЗадержкуЗарплаты,
        [Description1C8(Name = "МатериальнаяПомощь", Comment = "", Synonym = "Материальная помощь")]
        МатериальнаяПомощь,
        [Description1C8(Name = "НачислениеЗарплаты", Comment = "", Synonym = "Начисление зарплаты")]
        НачислениеЗарплаты,
        [Description1C8(Name = "ОплатаДнейУходаЗаДетьмиИнвалидами", Comment = "", Synonym = "ѳ(не украинский) Оплата дней ухода за детьми-инвалидами")]
        ОплатаДнейУходаЗаДетьмиИнвалидами,
        [Description1C8(Name = "ОплатаПоСреднемуЗаработку", Comment = "", Synonym = "Оплата по среднему заработку")]
        ОплатаПоСреднемуЗаработку,
        [Description1C8(Name = "Отпуск", Comment = "", Synonym = "Отпуск")]
        Отпуск,
        [Description1C8(Name = "ОтпускПоУходуЗаРебенком", Comment = "", Synonym = "ѳ(не украинский) Отпуск по уходу за ребенком")]
        ОтпускПоУходуЗаРебенком,
        [Description1C8(Name = "Премия", Comment = "", Synonym = "Премия")]
        Премия,
        [Description1C8(Name = "ПростойСотрудников", Comment = "", Synonym = "Простой сотрудников")]
        ПростойСотрудников,
        [Description1C8(Name = "РазовоеНачисление", Comment = "", Synonym = "Разовое начисление")]
        РазовоеНачисление,
        [Description1C8(Name = "Увольнение", Comment = "", Synonym = "Увольнение")]
        Увольнение
    }
}
