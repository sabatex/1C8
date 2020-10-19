using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНачисленийДляТиповыхОтчетов:V1C8COMObject
    {
        public ВидыНачисленийДляТиповыхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БольничныеЗаСчетПредприятия => GetProperty<EnumItemBase>("БольничныеЗаСчетПредприятия");
        public EnumItemBase ВзносыПредприятийНаМедИПенсСтрахование => GetProperty<EnumItemBase>("ВзносыПредприятийНаМедИПенсСтрахование");
        public EnumItemBase ВысокоеПрофессиональноеМастерство => GetProperty<EnumItemBase>("ВысокоеПрофессиональноеМастерство");
        public EnumItemBase ВознагражденияРазовогоХарактера => GetProperty<EnumItemBase>("ВознагражденияРазовогоХарактера");
        public EnumItemBase ВыплатыСоциальногоХарактера => GetProperty<EnumItemBase>("ВыплатыСоциальногоХарактера");
        public EnumItemBase ВыполнениеОбязанностейВременноОтсутствующегоРаботника => GetProperty<EnumItemBase>("ВыполнениеОбязанностейВременноОтсутствующегоРаботника");
        public EnumItemBase ВыполнениеОсобоВажнойРаботы => GetProperty<EnumItemBase>("ВыполнениеОсобоВажнойРаботы");
        public EnumItemBase ВысокиеДостиженияТруда => GetProperty<EnumItemBase>("ВысокиеДостиженияТруда");
        public EnumItemBase ГонорарАвторскоеВознаграждение => GetProperty<EnumItemBase>("ГонорарАвторскоеВознаграждение");
        public EnumItemBase ДивидендыПроцентыВыплатыЗаПаями => GetProperty<EnumItemBase>("ДивидендыПроцентыВыплатыЗаПаями");
        public EnumItemBase ДопускКГосударственнойТайне => GetProperty<EnumItemBase>("ДопускКГосударственнойТайне");
        public EnumItemBase ДругиеВидыНачисленийДопФОТ => GetProperty<EnumItemBase>("ДругиеВидыНачисленийДопФОТ");
        public EnumItemBase ДругиеВидыНачисленийНеФОТ => GetProperty<EnumItemBase>("ДругиеВидыНачисленийНеФОТ");
        public EnumItemBase ДругиеВидыНачисленийФОТ => GetProperty<EnumItemBase>("ДругиеВидыНачисленийФОТ");
        public EnumItemBase ДругиеВыплатыНеФОТ => GetProperty<EnumItemBase>("ДругиеВыплатыНеФОТ");
        public EnumItemBase ДругиеНадбавкиИДоплаты => GetProperty<EnumItemBase>("ДругиеНадбавкиИДоплаты");
        public EnumItemBase ДругиеНачисленияЗаНеотработанноеВремя => GetProperty<EnumItemBase>("ДругиеНачисленияЗаНеотработанноеВремя");
        public EnumItemBase ДругиеПоощрительныеИКомпенсационныеВыплаты => GetProperty<EnumItemBase>("ДругиеПоощрительныеИКомпенсационныеВыплаты");
        public EnumItemBase ЗначениеПеречисления1 => GetProperty<EnumItemBase>("ЗначениеПеречисления1");
        public EnumItemBase ЗатратыНаБесплатныйПроезд => GetProperty<EnumItemBase>("ЗатратыНаБесплатныйПроезд");
        public EnumItemBase ЗатратыНаКомандировки => GetProperty<EnumItemBase>("ЗатратыНаКомандировки");
        public EnumItemBase ЗнаниеИностранногоЯзыка => GetProperty<EnumItemBase>("ЗнаниеИностранногоЯзыка");
        public EnumItemBase ИндексацияЗарплаты => GetProperty<EnumItemBase>("ИндексацияЗарплаты");
        public EnumItemBase ИнтенсивностьТруда => GetProperty<EnumItemBase>("ИнтенсивностьТруда");
        public EnumItemBase КлассностьВодителямТранспортныхСредств => GetProperty<EnumItemBase>("КлассностьВодителямТранспортныхСредств");
        public EnumItemBase КомиссионныеОтРеализацииПродукции => GetProperty<EnumItemBase>("КомиссионныеОтРеализацииПродукции");
        public EnumItemBase КомпенсацияЗаНарушениеСроковВыплатыЗП => GetProperty<EnumItemBase>("КомпенсацияЗаНарушениеСроковВыплатыЗП");
        public EnumItemBase МатпомощьРазовогоХарактера => GetProperty<EnumItemBase>("МатпомощьРазовогоХарактера");
        public EnumItemBase НаучнаяСтепень => GetProperty<EnumItemBase>("НаучнаяСтепень");
        public EnumItemBase НормативноеВремяПередвиженияВШахте => GetProperty<EnumItemBase>("НормативноеВремяПередвиженияВШахте");
        public EnumItemBase ОплатаДнейОтдыха => GetProperty<EnumItemBase>("ОплатаДнейОтдыха");
        public EnumItemBase ОплатаЗаПрофобучение => GetProperty<EnumItemBase>("ОплатаЗаПрофобучение");
        public EnumItemBase ОплатаРаботыСверхурочноВПраздникиНерабочиеДни => GetProperty<EnumItemBase>("ОплатаРаботыСверхурочноВПраздникиНерабочиеДни");
        public EnumItemBase ОплатаТрудаВКомандировке => GetProperty<EnumItemBase>("ОплатаТрудаВКомандировке");
        public EnumItemBase Отпускные => GetProperty<EnumItemBase>("Отпускные");
        public EnumItemBase ПомощьИДругиеВыплатыЗаСчетФСС => GetProperty<EnumItemBase>("ПомощьИДругиеВыплатыЗаСчетФСС");
        public EnumItemBase Премия => GetProperty<EnumItemBase>("Премия");
        public EnumItemBase ПроцентныеКомиссионныеВознаграждения => GetProperty<EnumItemBase>("ПроцентныеКомиссионныеВознаграждения");
        public EnumItemBase РаботаВНочноеВремя => GetProperty<EnumItemBase>("РаботаВНочноеВремя");
        public EnumItemBase РаботаВТяжелыхВредныхУсловиях => GetProperty<EnumItemBase>("РаботаВТяжелыхВредныхУсловиях");
        public EnumItemBase РаботаНаТерриторияхРадиоактивногоЗагрязнения => GetProperty<EnumItemBase>("РаботаНаТерриторияхРадиоактивногоЗагрязнения");
        public EnumItemBase РангиЗвания => GetProperty<EnumItemBase>("РангиЗвания");
        public EnumItemBase РасширениеЗоныОбслуживания => GetProperty<EnumItemBase>("РасширениеЗоныОбслуживания");
        public EnumItemBase РуководствоБригадой => GetProperty<EnumItemBase>("РуководствоБригадой");
        public EnumItemBase СистематическаяМатпомощь => GetProperty<EnumItemBase>("СистематическаяМатпомощь");
        public EnumItemBase СовмещениеПрофессий => GetProperty<EnumItemBase>("СовмещениеПрофессий");
        public EnumItemBase СтоимостьПродукцииПриНатуральнойОплатеТруда => GetProperty<EnumItemBase>("СтоимостьПродукцииПриНатуральнойОплатеТруда");
        public EnumItemBase СтоимостьФорменнойОдежды => GetProperty<EnumItemBase>("СтоимостьФорменнойОдежды");
        public EnumItemBase ТарифнаяСтавкаОклад => GetProperty<EnumItemBase>("ТарифнаяСтавкаОклад");
        public EnumItemBase ПрофсоюзныйВзнос => GetProperty<EnumItemBase>("ПрофсоюзныйВзнос");
    }
}
