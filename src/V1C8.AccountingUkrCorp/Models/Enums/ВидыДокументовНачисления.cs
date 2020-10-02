using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДокументовНачисления", Comment = "", Synonym = "Виды документов начисления")]
    public class ВидыДокументовНачисления:EnumItem
    {
        public static readonly ВидыДокументовНачисления БольничныйЛист = new ВидыДокументовНачисления{Name= "БольничныйЛист",Synonim="Больничный лист",Comment=""};
        public static readonly ВидыДокументовНачисления ДоходВНатуральнойФорме = new ВидыДокументовНачисления{Name= "ДоходВНатуральнойФорме",Synonim="Доход в натуральной форме",Comment=""};
        public static readonly ВидыДокументовНачисления Командировка = new ВидыДокументовНачисления{Name= "Командировка",Synonim="Командировка",Comment=""};
        public static readonly ВидыДокументовНачисления МатериальнаяПомощь = new ВидыДокументовНачисления{Name= "МатериальнаяПомощь",Synonim="Материальная помощь",Comment=""};
        public static readonly ВидыДокументовНачисления ОплатаДнейУходаЗаДетьмиИнвалидами = new ВидыДокументовНачисления{Name= "ОплатаДнейУходаЗаДетьмиИнвалидами",Synonim="ѳ(не украинский) Оплата дней ухода за детьми инвалидами",Comment=""};
        public static readonly ВидыДокументовНачисления ОплатаПоСреднемуЗаработку = new ВидыДокументовНачисления{Name= "ОплатаПоСреднемуЗаработку",Synonim="Отсутствие с сохранением оплаты",Comment=""};
        public static readonly ВидыДокументовНачисления Отпуск = new ВидыДокументовНачисления{Name= "Отпуск",Synonim="Отпуск",Comment=""};
        public static readonly ВидыДокументовНачисления ОтпускБезСохраненияОплаты = new ВидыДокументовНачисления{Name= "ОтпускБезСохраненияОплаты",Synonim="Отпуск без сохранения оплаты",Comment=""};
        public static readonly ВидыДокументовНачисления Премия = new ВидыДокументовНачисления{Name= "Премия",Synonim="Премия",Comment=""};
        public static readonly ВидыДокументовНачисления ПрогулНеявка = new ВидыДокументовНачисления{Name= "ПрогулНеявка",Synonim="Прогул, неявка",Comment=""};
        public static readonly ВидыДокументовНачисления ПростойСотрудников = new ВидыДокументовНачисления{Name= "ПростойСотрудников",Synonim="Простой сотрудников",Comment=""};
        public static readonly ВидыДокументовНачисления РазовоеНачисление = new ВидыДокументовНачисления{Name= "РазовоеНачисление",Synonim="Разовое начисление",Comment=""};
        public static readonly ВидыДокументовНачисления Увольнение = new ВидыДокументовНачисления{Name= "Увольнение",Synonim="Увольнение",Comment=""};
        public static readonly ВидыДокументовНачисления Отгул = new ВидыДокументовНачисления{Name= "Отгул",Synonim="Отгул",Comment=""};
    }
}
