using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДокументовНачисления", Comment = "", Synonym = "Виды документов начисления")]
    public enum ВидыДокументовНачисления
    {
        [Description1C8(Name = "БольничныйЛист", Comment = "", Synonym = "Больничный лист")]
        БольничныйЛист,
        [Description1C8(Name = "ДоходВНатуральнойФорме", Comment = "", Synonym = "Доход в натуральной форме")]
        ДоходВНатуральнойФорме,
        [Description1C8(Name = "Командировка", Comment = "", Synonym = "Командировка")]
        Командировка,
        [Description1C8(Name = "МатериальнаяПомощь", Comment = "", Synonym = "Материальная помощь")]
        МатериальнаяПомощь,
        [Description1C8(Name = "ОплатаДнейУходаЗаДетьмиИнвалидами", Comment = "", Synonym = "ѳ(не украинский) Оплата дней ухода за детьми инвалидами")]
        ОплатаДнейУходаЗаДетьмиИнвалидами,
        [Description1C8(Name = "ОплатаПоСреднемуЗаработку", Comment = "", Synonym = "Отсутствие с сохранением оплаты")]
        ОплатаПоСреднемуЗаработку,
        [Description1C8(Name = "Отпуск", Comment = "", Synonym = "Отпуск")]
        Отпуск,
        [Description1C8(Name = "ОтпускБезСохраненияОплаты", Comment = "", Synonym = "Отпуск без сохранения оплаты")]
        ОтпускБезСохраненияОплаты,
        [Description1C8(Name = "Премия", Comment = "", Synonym = "Премия")]
        Премия,
        [Description1C8(Name = "ПрогулНеявка", Comment = "", Synonym = "Прогул, неявка")]
        ПрогулНеявка,
        [Description1C8(Name = "ПростойСотрудников", Comment = "", Synonym = "Простой сотрудников")]
        ПростойСотрудников,
        [Description1C8(Name = "РазовоеНачисление", Comment = "", Synonym = "Разовое начисление")]
        РазовоеНачисление,
        [Description1C8(Name = "Увольнение", Comment = "", Synonym = "Увольнение")]
        Увольнение,
        [Description1C8(Name = "Отгул", Comment = "", Synonym = "Отгул")]
        Отгул
    }
}
