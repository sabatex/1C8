using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииНачисленийИНеоплаченногоВремени:EnumBase
    {
        public КатегорииНачисленийИНеоплаченногоВремени(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПовременнаяОплатаТруда => GetProperty<EnumItem>("ПовременнаяОплатаТруда");
        public EnumItem ОплатаПоДоговоруГПХ => GetProperty<EnumItem>("ОплатаПоДоговоруГПХ");
        public EnumItem Доплата => GetProperty<EnumItem>("Доплата");
        public EnumItem СдельнаяОплатаТруда => GetProperty<EnumItem>("СдельнаяОплатаТруда");
        public EnumItem ОплатаТрудаВНатуральнойФорме => GetProperty<EnumItem>("ОплатаТрудаВНатуральнойФорме");
        public EnumItem ДоходВНатуральнойФорме => GetProperty<EnumItem>("ДоходВНатуральнойФорме");
        public EnumItem КомпенсационныеВыплаты => GetProperty<EnumItem>("КомпенсационныеВыплаты");
        public EnumItem Премия => GetProperty<EnumItem>("Премия");
        public EnumItem РайонныйКоэффициент => GetProperty<EnumItem>("РайонныйКоэффициент");
        public EnumItem СевернаяНадбавка => GetProperty<EnumItem>("СевернаяНадбавка");
        public EnumItem ДенежноеСодержаниеНаПериодОтпуска => GetProperty<EnumItem>("ДенежноеСодержаниеНаПериодОтпуска");
        public EnumItem ДенежноеСодержаниеКомпенсацияОтпуска => GetProperty<EnumItem>("ДенежноеСодержаниеКомпенсацияОтпуска");
        public EnumItem Индексация => GetProperty<EnumItem>("Индексация");
        public EnumItem КомпенсацияОтпуска => GetProperty<EnumItem>("КомпенсацияОтпуска");
        public EnumItem ЕдиновременнаяВыплатаКОтпускуГосслужащего => GetProperty<EnumItem>("ЕдиновременнаяВыплатаКОтпускуГосслужащего");
        public EnumItem ЕдиновременнаяВыплатаКОтпуску => GetProperty<EnumItem>("ЕдиновременнаяВыплатаКОтпуску");
        public EnumItem МатериальнаяПомощьПриОтпускеГосслужащего => GetProperty<EnumItem>("МатериальнаяПомощьПриОтпускеГосслужащего");
        public EnumItem МатериальнаяПомощьПриОтпуске => GetProperty<EnumItem>("МатериальнаяПомощьПриОтпуске");
        public EnumItem ДоплатаДоМЗП => GetProperty<EnumItem>("ДоплатаДоМЗП");
        public EnumItem НеявкаПоНевыясненнымПричинам => GetProperty<EnumItem>("НеявкаПоНевыясненнымПричинам");
        public EnumItem Прогул => GetProperty<EnumItem>("Прогул");
        public EnumItem ПростойПоВинеРаботника => GetProperty<EnumItem>("ПростойПоВинеРаботника");
        public EnumItem ОплатаПростояПоВинеРаботодателя => GetProperty<EnumItem>("ОплатаПростояПоВинеРаботодателя");
        public EnumItem ОплатаПростояПоНезависящимОтРаботодателяПричинам => GetProperty<EnumItem>("ОплатаПростояПоНезависящимОтРаботодателяПричинам");
        public EnumItem ДенежноеСодержаниеНаПериодКомандировки => GetProperty<EnumItem>("ДенежноеСодержаниеНаПериодКомандировки");
        public EnumItem ОплатаКомандировки => GetProperty<EnumItem>("ОплатаКомандировки");
        public EnumItem СохраняемоеДенежноеСодержание => GetProperty<EnumItem>("СохраняемоеДенежноеСодержание");
        public EnumItem ОплатаПоСреднемуЗаработку => GetProperty<EnumItem>("ОплатаПоСреднемуЗаработку");
        public EnumItem ДоплатаДоСреднегоЗаработка => GetProperty<EnumItem>("ДоплатаДоСреднегоЗаработка");
        public EnumItem ОплатаОтпуска => GetProperty<EnumItem>("ОплатаОтпуска");
        public EnumItem ОтпускБезОплаты => GetProperty<EnumItem>("ОтпускБезОплаты");
        public EnumItem ОплатаБольничногоЛиста => GetProperty<EnumItem>("ОплатаБольничногоЛиста");
        public EnumItem ОплатаБольничногоПрофзаболевание => GetProperty<EnumItem>("ОплатаБольничногоПрофзаболевание");
        public EnumItem ОплатаБольничногоЛистаЗаСчетРаботодателя => GetProperty<EnumItem>("ОплатаБольничногоЛистаЗаСчетРаботодателя");
        public EnumItem ДоплатаДоСреднегоЗаработкаЗаДниБолезни => GetProperty<EnumItem>("ДоплатаДоСреднегоЗаработкаЗаДниБолезни");
        public EnumItem ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItem>("ОплатаДнейУходаЗаДетьмиИнвалидами");
        public EnumItem ПособиеПоУходуЗаРебенкомДоПолутораЛет => GetProperty<EnumItem>("ПособиеПоУходуЗаРебенкомДоПолутораЛет");
        public EnumItem ПособиеПоУходуЗаРебенкомДоТрехЛет => GetProperty<EnumItem>("ПособиеПоУходуЗаРебенкомДоТрехЛет");
        public EnumItem ВыходноеПособиеМесячноеДенежноеСодержание => GetProperty<EnumItem>("ВыходноеПособиеМесячноеДенежноеСодержание");
        public EnumItem ВыходноеПособие => GetProperty<EnumItem>("ВыходноеПособие");
        public EnumItem ДоплатаЗаСовмещение => GetProperty<EnumItem>("ДоплатаЗаСовмещение");
        public EnumItem БолезньБезОплаты => GetProperty<EnumItem>("БолезньБезОплаты");
        public EnumItem ОтпускПоБеременностиИРодамБезОплаты => GetProperty<EnumItem>("ОтпускПоБеременностиИРодамБезОплаты");
        public EnumItem ОплатаБольничногоНесчастныйСлучайНаПроизводстве => GetProperty<EnumItem>("ОплатаБольничногоНесчастныйСлучайНаПроизводстве");
        public EnumItem ОтпускПоБеременностиИРодам => GetProperty<EnumItem>("ОтпускПоБеременностиИРодам");
        public EnumItem ОтпускПоУходуЗаРебенкомДо3Лет => GetProperty<EnumItem>("ОтпускПоУходуЗаРебенкомДо3Лет");
        public EnumItem ОтпускПоУходуЗаРебенкомДо6Лет => GetProperty<EnumItem>("ОтпускПоУходуЗаРебенкомДо6Лет");
        public EnumItem НачисленияМобилизованным => GetProperty<EnumItem>("НачисленияМобилизованным");
        public EnumItem ПрогулИлиНеявка => GetProperty<EnumItem>("ПрогулИлиНеявка");
        public EnumItem ЗаработокНаВремяТрудоустройства => GetProperty<EnumItem>("ЗаработокНаВремяТрудоустройства");
        public EnumItem МатериальнаяПомощь => GetProperty<EnumItem>("МатериальнаяПомощь");
        public EnumItem Льгота => GetProperty<EnumItem>("Льгота");
        public EnumItem НадбавкаЗаВредность => GetProperty<EnumItem>("НадбавкаЗаВредность");
        public EnumItem ОтпускНаСанаторноКурортноеЛечение => GetProperty<EnumItem>("ОтпускНаСанаторноКурортноеЛечение");
        public EnumItem Отгул => GetProperty<EnumItem>("Отгул");
        public EnumItem ОплатаПредыдущимиДокументами => GetProperty<EnumItem>("ОплатаПредыдущимиДокументами");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
        public EnumItem ДоплатаДоДенежногоСодержанияЗаДниБолезни => GetProperty<EnumItem>("ДоплатаДоДенежногоСодержанияЗаДниБолезни");
    }
}
