using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыНачисленийДляТиповыхОтчетов:V1C8COMObject
    {
        public ВидыНачисленийДляТиповыхОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БольничныеЗаСчетПредприятия => GetProperty<EnumItemBase>();
        public EnumItemBase ВзносыПредприятийНаМедИПенсСтрахование => GetProperty<EnumItemBase>();
        public EnumItemBase ВысокоеПрофессиональноеМастерство => GetProperty<EnumItemBase>();
        public EnumItemBase ВознагражденияРазовогоХарактера => GetProperty<EnumItemBase>();
        public EnumItemBase ВыплатыСоциальногоХарактера => GetProperty<EnumItemBase>();
        public EnumItemBase ВыполнениеОбязанностейВременноОтсутствующегоРаботника => GetProperty<EnumItemBase>();
        public EnumItemBase ВыполнениеОсобоВажнойРаботы => GetProperty<EnumItemBase>();
        public EnumItemBase ВысокиеДостиженияТруда => GetProperty<EnumItemBase>();
        public EnumItemBase ГонорарАвторскоеВознаграждение => GetProperty<EnumItemBase>();
        public EnumItemBase ДивидендыПроцентыВыплатыЗаПаями => GetProperty<EnumItemBase>();
        public EnumItemBase ДопускКГосударственнойТайне => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеВидыНачисленийДопФОТ => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеВидыНачисленийНеФОТ => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеВидыНачисленийФОТ => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеВыплатыНеФОТ => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеНадбавкиИДоплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеНачисленияЗаНеотработанноеВремя => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеПоощрительныеИКомпенсационныеВыплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ЗначениеПеречисления1 => GetProperty<EnumItemBase>();
        public EnumItemBase ЗатратыНаБесплатныйПроезд => GetProperty<EnumItemBase>();
        public EnumItemBase ЗатратыНаКомандировки => GetProperty<EnumItemBase>();
        public EnumItemBase ЗнаниеИностранногоЯзыка => GetProperty<EnumItemBase>();
        public EnumItemBase ИндексацияЗарплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ИнтенсивностьТруда => GetProperty<EnumItemBase>();
        public EnumItemBase КлассностьВодителямТранспортныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase КомиссионныеОтРеализацииПродукции => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсацияЗаНарушениеСроковВыплатыЗП => GetProperty<EnumItemBase>();
        public EnumItemBase МатпомощьРазовогоХарактера => GetProperty<EnumItemBase>();
        public EnumItemBase НаучнаяСтепень => GetProperty<EnumItemBase>();
        public EnumItemBase НормативноеВремяПередвиженияВШахте => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаДнейОтдыха => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаЗаПрофобучение => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаРаботыСверхурочноВПраздникиНерабочиеДни => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаТрудаВКомандировке => GetProperty<EnumItemBase>();
        public EnumItemBase Отпускные => GetProperty<EnumItemBase>();
        public EnumItemBase ПомощьИДругиеВыплатыЗаСчетФСС => GetProperty<EnumItemBase>();
        public EnumItemBase Премия => GetProperty<EnumItemBase>();
        public EnumItemBase ПроцентныеКомиссионныеВознаграждения => GetProperty<EnumItemBase>();
        public EnumItemBase РаботаВНочноеВремя => GetProperty<EnumItemBase>();
        public EnumItemBase РаботаВТяжелыхВредныхУсловиях => GetProperty<EnumItemBase>();
        public EnumItemBase РаботаНаТерриторияхРадиоактивногоЗагрязнения => GetProperty<EnumItemBase>();
        public EnumItemBase РангиЗвания => GetProperty<EnumItemBase>();
        public EnumItemBase РасширениеЗоныОбслуживания => GetProperty<EnumItemBase>();
        public EnumItemBase РуководствоБригадой => GetProperty<EnumItemBase>();
        public EnumItemBase СистематическаяМатпомощь => GetProperty<EnumItemBase>();
        public EnumItemBase СовмещениеПрофессий => GetProperty<EnumItemBase>();
        public EnumItemBase СтоимостьПродукцииПриНатуральнойОплатеТруда => GetProperty<EnumItemBase>();
        public EnumItemBase СтоимостьФорменнойОдежды => GetProperty<EnumItemBase>();
        public EnumItemBase ТарифнаяСтавкаОклад => GetProperty<EnumItemBase>();
        public EnumItemBase ПрофсоюзныйВзнос => GetProperty<EnumItemBase>();
    }
}
