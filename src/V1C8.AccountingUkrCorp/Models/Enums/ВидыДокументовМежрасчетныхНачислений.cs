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
    [Table("VydyDokumentovMezhraschetnykhNachyslenyi")]
    [Description1C8(Name = "ВидыДокументовМежрасчетныхНачислений", Comment = "", Synonym = "Виды документов межрасчетных начислений")]
    public class ВидыДокументовМежрасчетныхНачислений:EnumItem
    {
        public static readonly ВидыДокументовМежрасчетныхНачислений БольничныйЛист = new ВидыДокументовМежрасчетныхНачислений{Name= "БольничныйЛист",Synonym="Больничный лист",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений ВозвратНДФЛ = new ВидыДокументовМежрасчетныхНачислений{Name= "ВозвратНДФЛ",Synonym="ѳ(не украинский) Возврат НДФЛ",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений ЕдиновременноеПособиеЗаСчетФСС = new ВидыДокументовМежрасчетныхНачислений{Name= "ЕдиновременноеПособиеЗаСчетФСС",Synonym="Единовременное пособие за счет ФСС",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений Командировка = new ВидыДокументовМежрасчетныхНачислений{Name= "Командировка",Synonym="Командировка",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений КомпенсацияЗаЗадержкуЗарплаты = new ВидыДокументовМежрасчетныхНачислений{Name= "КомпенсацияЗаЗадержкуЗарплаты",Synonym="Компенсация за задержку выплаты заработной платы",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений МатериальнаяПомощь = new ВидыДокументовМежрасчетныхНачислений{Name= "МатериальнаяПомощь",Synonym="Материальная помощь",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений НачислениеЗарплаты = new ВидыДокументовМежрасчетныхНачислений{Name= "НачислениеЗарплаты",Synonym="Начисление зарплаты",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений ОплатаДнейУходаЗаДетьмиИнвалидами = new ВидыДокументовМежрасчетныхНачислений{Name= "ОплатаДнейУходаЗаДетьмиИнвалидами",Synonym="ѳ(не украинский) Оплата дней ухода за детьми-инвалидами",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений ОплатаПоСреднемуЗаработку = new ВидыДокументовМежрасчетныхНачислений{Name= "ОплатаПоСреднемуЗаработку",Synonym="Оплата по среднему заработку",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений Отпуск = new ВидыДокументовМежрасчетныхНачислений{Name= "Отпуск",Synonym="Отпуск",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений ОтпускПоУходуЗаРебенком = new ВидыДокументовМежрасчетныхНачислений{Name= "ОтпускПоУходуЗаРебенком",Synonym="ѳ(не украинский) Отпуск по уходу за ребенком",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений Премия = new ВидыДокументовМежрасчетныхНачислений{Name= "Премия",Synonym="Премия",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений ПростойСотрудников = new ВидыДокументовМежрасчетныхНачислений{Name= "ПростойСотрудников",Synonym="Простой сотрудников",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений РазовоеНачисление = new ВидыДокументовМежрасчетныхНачислений{Name= "РазовоеНачисление",Synonym="Разовое начисление",Comment=""};
        public static readonly ВидыДокументовМежрасчетныхНачислений Увольнение = new ВидыДокументовМежрасчетныхНачислений{Name= "Увольнение",Synonym="Увольнение",Comment=""};
    }
}
