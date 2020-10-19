using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииНачисленийИНеоплаченногоВремени:V1C8COMObject
    {
        public КатегорииНачисленийИНеоплаченногоВремени(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПовременнаяОплатаТруда => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаПоДоговоруГПХ => GetProperty<EnumItemBase>();
        public EnumItemBase Доплата => GetProperty<EnumItemBase>();
        public EnumItemBase СдельнаяОплатаТруда => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаТрудаВНатуральнойФорме => GetProperty<EnumItemBase>();
        public EnumItemBase ДоходВНатуральнойФорме => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсационныеВыплаты => GetProperty<EnumItemBase>();
        public EnumItemBase Премия => GetProperty<EnumItemBase>();
        public EnumItemBase РайонныйКоэффициент => GetProperty<EnumItemBase>();
        public EnumItemBase СевернаяНадбавка => GetProperty<EnumItemBase>();
        public EnumItemBase ДенежноеСодержаниеНаПериодОтпуска => GetProperty<EnumItemBase>();
        public EnumItemBase ДенежноеСодержаниеКомпенсацияОтпуска => GetProperty<EnumItemBase>();
        public EnumItemBase Индексация => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсацияОтпуска => GetProperty<EnumItemBase>();
        public EnumItemBase ЕдиновременнаяВыплатаКОтпускуГосслужащего => GetProperty<EnumItemBase>();
        public EnumItemBase ЕдиновременнаяВыплатаКОтпуску => GetProperty<EnumItemBase>();
        public EnumItemBase МатериальнаяПомощьПриОтпускеГосслужащего => GetProperty<EnumItemBase>();
        public EnumItemBase МатериальнаяПомощьПриОтпуске => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоМЗП => GetProperty<EnumItemBase>();
        public EnumItemBase НеявкаПоНевыясненнымПричинам => GetProperty<EnumItemBase>();
        public EnumItemBase Прогул => GetProperty<EnumItemBase>();
        public EnumItemBase ПростойПоВинеРаботника => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаПростояПоВинеРаботодателя => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаПростояПоНезависящимОтРаботодателяПричинам => GetProperty<EnumItemBase>();
        public EnumItemBase ДенежноеСодержаниеНаПериодКомандировки => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаКомандировки => GetProperty<EnumItemBase>();
        public EnumItemBase СохраняемоеДенежноеСодержание => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаПоСреднемуЗаработку => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоСреднегоЗаработка => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаОтпуска => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускБезОплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаБольничногоЛиста => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаБольничногоПрофзаболевание => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаБольничногоЛистаЗаСчетРаботодателя => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоСреднегоЗаработкаЗаДниБолезни => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItemBase>();
        public EnumItemBase ПособиеПоУходуЗаРебенкомДоПолутораЛет => GetProperty<EnumItemBase>();
        public EnumItemBase ПособиеПоУходуЗаРебенкомДоТрехЛет => GetProperty<EnumItemBase>();
        public EnumItemBase ВыходноеПособиеМесячноеДенежноеСодержание => GetProperty<EnumItemBase>();
        public EnumItemBase ВыходноеПособие => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаЗаСовмещение => GetProperty<EnumItemBase>();
        public EnumItemBase БолезньБезОплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускПоБеременностиИРодамБезОплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаБольничногоНесчастныйСлучайНаПроизводстве => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускПоБеременностиИРодам => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускПоУходуЗаРебенкомДо3Лет => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускПоУходуЗаРебенкомДо6Лет => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленияМобилизованным => GetProperty<EnumItemBase>();
        public EnumItemBase ПрогулИлиНеявка => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаработокНаВремяТрудоустройства => GetProperty<EnumItemBase>();
        public EnumItemBase МатериальнаяПомощь => GetProperty<EnumItemBase>();
        public EnumItemBase Льгота => GetProperty<EnumItemBase>();
        public EnumItemBase НадбавкаЗаВредность => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускНаСанаторноКурортноеЛечение => GetProperty<EnumItemBase>();
        public EnumItemBase Отгул => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаПредыдущимиДокументами => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоДенежногоСодержанияЗаДниБолезни => GetProperty<EnumItemBase>();
    }
}
