using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНачисленийДляТиповыхОтчетов:EnumBase
    {
        public ВидыНачисленийДляТиповыхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem БольничныеЗаСчетПредприятия => GetProperty<EnumItem>("БольничныеЗаСчетПредприятия");
        public EnumItem ВзносыПредприятийНаМедИПенсСтрахование => GetProperty<EnumItem>("ВзносыПредприятийНаМедИПенсСтрахование");
        public EnumItem ВысокоеПрофессиональноеМастерство => GetProperty<EnumItem>("ВысокоеПрофессиональноеМастерство");
        public EnumItem ВознагражденияРазовогоХарактера => GetProperty<EnumItem>("ВознагражденияРазовогоХарактера");
        public EnumItem ВыплатыСоциальногоХарактера => GetProperty<EnumItem>("ВыплатыСоциальногоХарактера");
        public EnumItem ВыполнениеОбязанностейВременноОтсутствующегоРаботника => GetProperty<EnumItem>("ВыполнениеОбязанностейВременноОтсутствующегоРаботника");
        public EnumItem ВыполнениеОсобоВажнойРаботы => GetProperty<EnumItem>("ВыполнениеОсобоВажнойРаботы");
        public EnumItem ВысокиеДостиженияТруда => GetProperty<EnumItem>("ВысокиеДостиженияТруда");
        public EnumItem ГонорарАвторскоеВознаграждение => GetProperty<EnumItem>("ГонорарАвторскоеВознаграждение");
        public EnumItem ДивидендыПроцентыВыплатыЗаПаями => GetProperty<EnumItem>("ДивидендыПроцентыВыплатыЗаПаями");
        public EnumItem ДопускКГосударственнойТайне => GetProperty<EnumItem>("ДопускКГосударственнойТайне");
        public EnumItem ДругиеВидыНачисленийДопФОТ => GetProperty<EnumItem>("ДругиеВидыНачисленийДопФОТ");
        public EnumItem ДругиеВидыНачисленийНеФОТ => GetProperty<EnumItem>("ДругиеВидыНачисленийНеФОТ");
        public EnumItem ДругиеВидыНачисленийФОТ => GetProperty<EnumItem>("ДругиеВидыНачисленийФОТ");
        public EnumItem ДругиеВыплатыНеФОТ => GetProperty<EnumItem>("ДругиеВыплатыНеФОТ");
        public EnumItem ДругиеНадбавкиИДоплаты => GetProperty<EnumItem>("ДругиеНадбавкиИДоплаты");
        public EnumItem ДругиеНачисленияЗаНеотработанноеВремя => GetProperty<EnumItem>("ДругиеНачисленияЗаНеотработанноеВремя");
        public EnumItem ДругиеПоощрительныеИКомпенсационныеВыплаты => GetProperty<EnumItem>("ДругиеПоощрительныеИКомпенсационныеВыплаты");
        public EnumItem ЗначениеПеречисления1 => GetProperty<EnumItem>("ЗначениеПеречисления1");
        public EnumItem ЗатратыНаБесплатныйПроезд => GetProperty<EnumItem>("ЗатратыНаБесплатныйПроезд");
        public EnumItem ЗатратыНаКомандировки => GetProperty<EnumItem>("ЗатратыНаКомандировки");
        public EnumItem ЗнаниеИностранногоЯзыка => GetProperty<EnumItem>("ЗнаниеИностранногоЯзыка");
        public EnumItem ИндексацияЗарплаты => GetProperty<EnumItem>("ИндексацияЗарплаты");
        public EnumItem ИнтенсивностьТруда => GetProperty<EnumItem>("ИнтенсивностьТруда");
        public EnumItem КлассностьВодителямТранспортныхСредств => GetProperty<EnumItem>("КлассностьВодителямТранспортныхСредств");
        public EnumItem КомиссионныеОтРеализацииПродукции => GetProperty<EnumItem>("КомиссионныеОтРеализацииПродукции");
        public EnumItem КомпенсацияЗаНарушениеСроковВыплатыЗП => GetProperty<EnumItem>("КомпенсацияЗаНарушениеСроковВыплатыЗП");
        public EnumItem МатпомощьРазовогоХарактера => GetProperty<EnumItem>("МатпомощьРазовогоХарактера");
        public EnumItem НаучнаяСтепень => GetProperty<EnumItem>("НаучнаяСтепень");
        public EnumItem НормативноеВремяПередвиженияВШахте => GetProperty<EnumItem>("НормативноеВремяПередвиженияВШахте");
        public EnumItem ОплатаДнейОтдыха => GetProperty<EnumItem>("ОплатаДнейОтдыха");
        public EnumItem ОплатаЗаПрофобучение => GetProperty<EnumItem>("ОплатаЗаПрофобучение");
        public EnumItem ОплатаРаботыСверхурочноВПраздникиНерабочиеДни => GetProperty<EnumItem>("ОплатаРаботыСверхурочноВПраздникиНерабочиеДни");
        public EnumItem ОплатаТрудаВКомандировке => GetProperty<EnumItem>("ОплатаТрудаВКомандировке");
        public EnumItem Отпускные => GetProperty<EnumItem>("Отпускные");
        public EnumItem ПомощьИДругиеВыплатыЗаСчетФСС => GetProperty<EnumItem>("ПомощьИДругиеВыплатыЗаСчетФСС");
        public EnumItem Премия => GetProperty<EnumItem>("Премия");
        public EnumItem ПроцентныеКомиссионныеВознаграждения => GetProperty<EnumItem>("ПроцентныеКомиссионныеВознаграждения");
        public EnumItem РаботаВНочноеВремя => GetProperty<EnumItem>("РаботаВНочноеВремя");
        public EnumItem РаботаВТяжелыхВредныхУсловиях => GetProperty<EnumItem>("РаботаВТяжелыхВредныхУсловиях");
        public EnumItem РаботаНаТерриторияхРадиоактивногоЗагрязнения => GetProperty<EnumItem>("РаботаНаТерриторияхРадиоактивногоЗагрязнения");
        public EnumItem РангиЗвания => GetProperty<EnumItem>("РангиЗвания");
        public EnumItem РасширениеЗоныОбслуживания => GetProperty<EnumItem>("РасширениеЗоныОбслуживания");
        public EnumItem РуководствоБригадой => GetProperty<EnumItem>("РуководствоБригадой");
        public EnumItem СистематическаяМатпомощь => GetProperty<EnumItem>("СистематическаяМатпомощь");
        public EnumItem СовмещениеПрофессий => GetProperty<EnumItem>("СовмещениеПрофессий");
        public EnumItem СтоимостьПродукцииПриНатуральнойОплатеТруда => GetProperty<EnumItem>("СтоимостьПродукцииПриНатуральнойОплатеТруда");
        public EnumItem СтоимостьФорменнойОдежды => GetProperty<EnumItem>("СтоимостьФорменнойОдежды");
        public EnumItem ТарифнаяСтавкаОклад => GetProperty<EnumItem>("ТарифнаяСтавкаОклад");
        public EnumItem ПрофсоюзныйВзнос => GetProperty<EnumItem>("ПрофсоюзныйВзнос");
    }
}
