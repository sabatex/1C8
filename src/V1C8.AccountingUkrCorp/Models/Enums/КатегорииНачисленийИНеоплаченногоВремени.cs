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
    [Table("KatehoryyNachyslenyiYNeoplachennohoVremeny")]
    [Description1C8(Name = "КатегорииНачисленийИНеоплаченногоВремени", Comment = "", Synonym = "Категории начислений и неоплаченного времени")]
    public class КатегорииНачисленийИНеоплаченногоВремени:EnumItem
    {
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ПовременнаяОплатаТруда = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ПовременнаяОплатаТруда",Synonym="Повременная оплата труда и надбавки",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаПоДоговоруГПХ = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаПоДоговоруГПХ",Synonym="Оплата по договору ГПХ",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени Доплата = new КатегорииНачисленийИНеоплаченногоВремени{Name= "Доплата",Synonym="Доплата",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени СдельнаяОплатаТруда = new КатегорииНачисленийИНеоплаченногоВремени{Name= "СдельнаяОплатаТруда",Synonym="Сдельная оплата труда",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаТрудаВНатуральнойФорме = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаТрудаВНатуральнойФорме",Synonym="Оплата труда в натуральной форме",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДоходВНатуральнойФорме = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДоходВНатуральнойФорме",Synonym="Доход в натуральной форме",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени КомпенсационныеВыплаты = new КатегорииНачисленийИНеоплаченногоВремени{Name= "КомпенсационныеВыплаты",Synonym="Компенсационные выплаты",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени Премия = new КатегорииНачисленийИНеоплаченногоВремени{Name= "Премия",Synonym="Премия",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени РайонныйКоэффициент = new КатегорииНачисленийИНеоплаченногоВремени{Name= "РайонныйКоэффициент",Synonym="Районный коэффициент",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени СевернаяНадбавка = new КатегорииНачисленийИНеоплаченногоВремени{Name= "СевернаяНадбавка",Synonym="Северная надбавка",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДенежноеСодержаниеНаПериодОтпуска = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДенежноеСодержаниеНаПериодОтпуска",Synonym="Денежное содержание на период отпуска",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДенежноеСодержаниеКомпенсацияОтпуска = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДенежноеСодержаниеКомпенсацияОтпуска",Synonym="Денежное содержание компенсация отпуска",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени Индексация = new КатегорииНачисленийИНеоплаченногоВремени{Name= "Индексация",Synonym="Индексация зарплаты",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени КомпенсацияОтпуска = new КатегорииНачисленийИНеоплаченногоВремени{Name= "КомпенсацияОтпуска",Synonym="Компенсация отпуска",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ЕдиновременнаяВыплатаКОтпускуГосслужащего = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ЕдиновременнаяВыплатаКОтпускуГосслужащего",Synonym="Единовременная выплата к отпуску госслужащего",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ЕдиновременнаяВыплатаКОтпуску = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ЕдиновременнаяВыплатаКОтпуску",Synonym="Единовременная выплата к отпуску",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени МатериальнаяПомощьПриОтпускеГосслужащего = new КатегорииНачисленийИНеоплаченногоВремени{Name= "МатериальнаяПомощьПриОтпускеГосслужащего",Synonym="Материальная помощь к отпуску госслужащего",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени МатериальнаяПомощьПриОтпуске = new КатегорииНачисленийИНеоплаченногоВремени{Name= "МатериальнаяПомощьПриОтпуске",Synonym="Материальная помощь к отпуску",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДоплатаДоМЗП = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДоплатаДоМЗП",Synonym="Доплата до МЗП",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени НеявкаПоНевыясненнымПричинам = new КатегорииНачисленийИНеоплаченногоВремени{Name= "НеявкаПоНевыясненнымПричинам",Synonym="Неявка по невыясненным причинам",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени Прогул = new КатегорииНачисленийИНеоплаченногоВремени{Name= "Прогул",Synonym="Прогул",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ПростойПоВинеРаботника = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ПростойПоВинеРаботника",Synonym="Простой по вине работника",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаПростояПоВинеРаботодателя = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаПростояПоВинеРаботодателя",Synonym="Оплата простоя по вине работодателя",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаПростояПоНезависящимОтРаботодателяПричинам = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаПростояПоНезависящимОтРаботодателяПричинам",Synonym="Оплата простоя по независящим от работодателя причинам",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДенежноеСодержаниеНаПериодКомандировки = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДенежноеСодержаниеНаПериодКомандировки",Synonym="Денежное содержание на период командировки",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаКомандировки = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаКомандировки",Synonym="Оплата командировки",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени СохраняемоеДенежноеСодержание = new КатегорииНачисленийИНеоплаченногоВремени{Name= "СохраняемоеДенежноеСодержание",Synonym="Сохраняемое денежное содержание",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаПоСреднемуЗаработку = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаПоСреднемуЗаработку",Synonym="Оплата времени сохраняемого среднего заработка",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДоплатаДоСреднегоЗаработка = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДоплатаДоСреднегоЗаработка",Synonym="Доплата до среднего заработка",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаОтпуска = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаОтпуска",Synonym="Оплата отпуска",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОтпускБезОплаты = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОтпускБезОплаты",Synonym="Отпуск без оплаты",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаБольничногоЛиста = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаБольничногоЛиста",Synonym="Оплата больничного листа",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаБольничногоПрофзаболевание = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаБольничногоПрофзаболевание",Synonym="Оплата больничного листа, профзаболевание",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаБольничногоЛистаЗаСчетРаботодателя = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаБольничногоЛистаЗаСчетРаботодателя",Synonym="Оплата больничного листа за счет работодателя",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДоплатаДоСреднегоЗаработкаЗаДниБолезни = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДоплатаДоСреднегоЗаработкаЗаДниБолезни",Synonym="Доплата до среднего заработка за дни болезни",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаДнейУходаЗаДетьмиИнвалидами = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаДнейУходаЗаДетьмиИнвалидами",Synonym="ѳ(не украинский) Оплата дней ухода за детьми-инвалидами",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ПособиеПоУходуЗаРебенкомДоПолутораЛет = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ПособиеПоУходуЗаРебенкомДоПолутораЛет",Synonym="Отпуск по уходу за ребенком до шести лет",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ПособиеПоУходуЗаРебенкомДоТрехЛет = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ПособиеПоУходуЗаРебенкомДоТрехЛет",Synonym="Отпуск по уходу за ребенком до трех лет",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ВыходноеПособиеМесячноеДенежноеСодержание = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ВыходноеПособиеМесячноеДенежноеСодержание",Synonym="Выходное пособие (месячное денежное содержание)",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ВыходноеПособие = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ВыходноеПособие",Synonym="Выходное пособие",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДоплатаЗаСовмещение = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДоплатаЗаСовмещение",Synonym="Доплата за совмещение",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени БолезньБезОплаты = new КатегорииНачисленийИНеоплаченногоВремени{Name= "БолезньБезОплаты",Synonym="Болезнь без оплаты",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОтпускПоБеременностиИРодамБезОплаты = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОтпускПоБеременностиИРодамБезОплаты",Synonym="Отпуск по беременности и родам без оплаты",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаБольничногоНесчастныйСлучайНаПроизводстве = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаБольничногоНесчастныйСлучайНаПроизводстве",Synonym="Оплата больничного листа, несчастный случай на производстве",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОтпускПоБеременностиИРодам = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОтпускПоБеременностиИРодам",Synonym="Отпуск по беременности и родам",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОтпускПоУходуЗаРебенкомДо3Лет = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОтпускПоУходуЗаРебенкомДо3Лет",Synonym="Отпуск по уходу за ребенком до 3 лет",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОтпускПоУходуЗаРебенкомДо6Лет = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОтпускПоУходуЗаРебенкомДо6Лет",Synonym="Отпуск по уходу за ребенком до 6 лет",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени НачисленияМобилизованным = new КатегорииНачисленийИНеоплаченногоВремени{Name= "НачисленияМобилизованным",Synonym="Начисления мобилизованным",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ПрогулИлиНеявка = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ПрогулИлиНеявка",Synonym="Прогул или неявка",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ЗаработокНаВремяТрудоустройства = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ЗаработокНаВремяТрудоустройства",Synonym="Заработок на время трудоустройства",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени МатериальнаяПомощь = new КатегорииНачисленийИНеоплаченногоВремени{Name= "МатериальнаяПомощь",Synonym="Материальная помощь",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени Льгота = new КатегорииНачисленийИНеоплаченногоВремени{Name= "Льгота",Synonym="Льгота",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени НадбавкаЗаВредность = new КатегорииНачисленийИНеоплаченногоВремени{Name= "НадбавкаЗаВредность",Synonym="Надбавка за вредность",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОтпускНаСанаторноКурортноеЛечение = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОтпускНаСанаторноКурортноеЛечение",Synonym="Отпуск (за счет ФСС) на период санаторно-курортного лечения",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени Отгул = new КатегорииНачисленийИНеоплаченногоВремени{Name= "Отгул",Synonym="Отгул",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ОплатаПредыдущимиДокументами = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ОплатаПредыдущимиДокументами",Synonym="Оплата предыдущими документами",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени Прочее = new КатегорииНачисленийИНеоплаченногоВремени{Name= "Прочее",Synonym="Прочие начисления и выплаты",Comment=""};
        public static readonly КатегорииНачисленийИНеоплаченногоВремени ДоплатаДоДенежногоСодержанияЗаДниБолезни = new КатегорииНачисленийИНеоплаченногоВремени{Name= "ДоплатаДоДенежногоСодержанияЗаДниБолезни",Synonym="Доплата до денежного содержания за дни болезни",Comment=""};
    }
}
