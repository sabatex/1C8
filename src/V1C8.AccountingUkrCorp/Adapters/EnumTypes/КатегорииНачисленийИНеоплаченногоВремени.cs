using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииНачисленийИНеоплаченногоВремени:V1C8COMObject
    {
        public КатегорииНачисленийИНеоплаченногоВремени(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПовременнаяОплатаТруда => GetProperty<EnumItemBase>("ПовременнаяОплатаТруда");
        public EnumItemBase ОплатаПоДоговоруГПХ => GetProperty<EnumItemBase>("ОплатаПоДоговоруГПХ");
        public EnumItemBase Доплата => GetProperty<EnumItemBase>("Доплата");
        public EnumItemBase СдельнаяОплатаТруда => GetProperty<EnumItemBase>("СдельнаяОплатаТруда");
        public EnumItemBase ОплатаТрудаВНатуральнойФорме => GetProperty<EnumItemBase>("ОплатаТрудаВНатуральнойФорме");
        public EnumItemBase ДоходВНатуральнойФорме => GetProperty<EnumItemBase>("ДоходВНатуральнойФорме");
        public EnumItemBase КомпенсационныеВыплаты => GetProperty<EnumItemBase>("КомпенсационныеВыплаты");
        public EnumItemBase Премия => GetProperty<EnumItemBase>("Премия");
        public EnumItemBase РайонныйКоэффициент => GetProperty<EnumItemBase>("РайонныйКоэффициент");
        public EnumItemBase СевернаяНадбавка => GetProperty<EnumItemBase>("СевернаяНадбавка");
        public EnumItemBase ДенежноеСодержаниеНаПериодОтпуска => GetProperty<EnumItemBase>("ДенежноеСодержаниеНаПериодОтпуска");
        public EnumItemBase ДенежноеСодержаниеКомпенсацияОтпуска => GetProperty<EnumItemBase>("ДенежноеСодержаниеКомпенсацияОтпуска");
        public EnumItemBase Индексация => GetProperty<EnumItemBase>("Индексация");
        public EnumItemBase КомпенсацияОтпуска => GetProperty<EnumItemBase>("КомпенсацияОтпуска");
        public EnumItemBase ЕдиновременнаяВыплатаКОтпускуГосслужащего => GetProperty<EnumItemBase>("ЕдиновременнаяВыплатаКОтпускуГосслужащего");
        public EnumItemBase ЕдиновременнаяВыплатаКОтпуску => GetProperty<EnumItemBase>("ЕдиновременнаяВыплатаКОтпуску");
        public EnumItemBase МатериальнаяПомощьПриОтпускеГосслужащего => GetProperty<EnumItemBase>("МатериальнаяПомощьПриОтпускеГосслужащего");
        public EnumItemBase МатериальнаяПомощьПриОтпуске => GetProperty<EnumItemBase>("МатериальнаяПомощьПриОтпуске");
        public EnumItemBase ДоплатаДоМЗП => GetProperty<EnumItemBase>("ДоплатаДоМЗП");
        public EnumItemBase НеявкаПоНевыясненнымПричинам => GetProperty<EnumItemBase>("НеявкаПоНевыясненнымПричинам");
        public EnumItemBase Прогул => GetProperty<EnumItemBase>("Прогул");
        public EnumItemBase ПростойПоВинеРаботника => GetProperty<EnumItemBase>("ПростойПоВинеРаботника");
        public EnumItemBase ОплатаПростояПоВинеРаботодателя => GetProperty<EnumItemBase>("ОплатаПростояПоВинеРаботодателя");
        public EnumItemBase ОплатаПростояПоНезависящимОтРаботодателяПричинам => GetProperty<EnumItemBase>("ОплатаПростояПоНезависящимОтРаботодателяПричинам");
        public EnumItemBase ДенежноеСодержаниеНаПериодКомандировки => GetProperty<EnumItemBase>("ДенежноеСодержаниеНаПериодКомандировки");
        public EnumItemBase ОплатаКомандировки => GetProperty<EnumItemBase>("ОплатаКомандировки");
        public EnumItemBase СохраняемоеДенежноеСодержание => GetProperty<EnumItemBase>("СохраняемоеДенежноеСодержание");
        public EnumItemBase ОплатаПоСреднемуЗаработку => GetProperty<EnumItemBase>("ОплатаПоСреднемуЗаработку");
        public EnumItemBase ДоплатаДоСреднегоЗаработка => GetProperty<EnumItemBase>("ДоплатаДоСреднегоЗаработка");
        public EnumItemBase ОплатаОтпуска => GetProperty<EnumItemBase>("ОплатаОтпуска");
        public EnumItemBase ОтпускБезОплаты => GetProperty<EnumItemBase>("ОтпускБезОплаты");
        public EnumItemBase ОплатаБольничногоЛиста => GetProperty<EnumItemBase>("ОплатаБольничногоЛиста");
        public EnumItemBase ОплатаБольничногоПрофзаболевание => GetProperty<EnumItemBase>("ОплатаБольничногоПрофзаболевание");
        public EnumItemBase ОплатаБольничногоЛистаЗаСчетРаботодателя => GetProperty<EnumItemBase>("ОплатаБольничногоЛистаЗаСчетРаботодателя");
        public EnumItemBase ДоплатаДоСреднегоЗаработкаЗаДниБолезни => GetProperty<EnumItemBase>("ДоплатаДоСреднегоЗаработкаЗаДниБолезни");
        public EnumItemBase ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItemBase>("ОплатаДнейУходаЗаДетьмиИнвалидами");
        public EnumItemBase ПособиеПоУходуЗаРебенкомДоПолутораЛет => GetProperty<EnumItemBase>("ПособиеПоУходуЗаРебенкомДоПолутораЛет");
        public EnumItemBase ПособиеПоУходуЗаРебенкомДоТрехЛет => GetProperty<EnumItemBase>("ПособиеПоУходуЗаРебенкомДоТрехЛет");
        public EnumItemBase ВыходноеПособиеМесячноеДенежноеСодержание => GetProperty<EnumItemBase>("ВыходноеПособиеМесячноеДенежноеСодержание");
        public EnumItemBase ВыходноеПособие => GetProperty<EnumItemBase>("ВыходноеПособие");
        public EnumItemBase ДоплатаЗаСовмещение => GetProperty<EnumItemBase>("ДоплатаЗаСовмещение");
        public EnumItemBase БолезньБезОплаты => GetProperty<EnumItemBase>("БолезньБезОплаты");
        public EnumItemBase ОтпускПоБеременностиИРодамБезОплаты => GetProperty<EnumItemBase>("ОтпускПоБеременностиИРодамБезОплаты");
        public EnumItemBase ОплатаБольничногоНесчастныйСлучайНаПроизводстве => GetProperty<EnumItemBase>("ОплатаБольничногоНесчастныйСлучайНаПроизводстве");
        public EnumItemBase ОтпускПоБеременностиИРодам => GetProperty<EnumItemBase>("ОтпускПоБеременностиИРодам");
        public EnumItemBase ОтпускПоУходуЗаРебенкомДо3Лет => GetProperty<EnumItemBase>("ОтпускПоУходуЗаРебенкомДо3Лет");
        public EnumItemBase ОтпускПоУходуЗаРебенкомДо6Лет => GetProperty<EnumItemBase>("ОтпускПоУходуЗаРебенкомДо6Лет");
        public EnumItemBase НачисленияМобилизованным => GetProperty<EnumItemBase>("НачисленияМобилизованным");
        public EnumItemBase ПрогулИлиНеявка => GetProperty<EnumItemBase>("ПрогулИлиНеявка");
        public EnumItemBase ЗаработокНаВремяТрудоустройства => GetProperty<EnumItemBase>("ЗаработокНаВремяТрудоустройства");
        public EnumItemBase МатериальнаяПомощь => GetProperty<EnumItemBase>("МатериальнаяПомощь");
        public EnumItemBase Льгота => GetProperty<EnumItemBase>("Льгота");
        public EnumItemBase НадбавкаЗаВредность => GetProperty<EnumItemBase>("НадбавкаЗаВредность");
        public EnumItemBase ОтпускНаСанаторноКурортноеЛечение => GetProperty<EnumItemBase>("ОтпускНаСанаторноКурортноеЛечение");
        public EnumItemBase Отгул => GetProperty<EnumItemBase>("Отгул");
        public EnumItemBase ОплатаПредыдущимиДокументами => GetProperty<EnumItemBase>("ОплатаПредыдущимиДокументами");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
        public EnumItemBase ДоплатаДоДенежногоСодержанияЗаДниБолезни => GetProperty<EnumItemBase>("ДоплатаДоДенежногоСодержанияЗаДниБолезни");
    }
}
