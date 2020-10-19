using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПоЗарплате:V1C8COMObject
    {
        public ВидыОперацийПоЗарплате(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НачисленоДоход => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленоБольничные => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленоОтпускныеДоход => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленоОтпускныеРезерв => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратИзлишнеВыплаченныхСуммВследствиеСчетныхОшибок => GetProperty<EnumItemBase>();
        public EnumItemBase ВозмещениеУщерба => GetProperty<EnumItemBase>();
        public EnumItemBase ВознаграждениеПлатежногоАгента => GetProperty<EnumItemBase>();
        public EnumItemBase ВыплатыБывшимСотрудникам => GetProperty<EnumItemBase>();
        public EnumItemBase НатуральныйДоход => GetProperty<EnumItemBase>();
        public EnumItemBase Дивиденды => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленоСдельноДоход => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленоЗаСчетФССДоход => GetProperty<EnumItemBase>();
        public EnumItemBase ДивидендыСотрудников => GetProperty<EnumItemBase>();
        public EnumItemBase ДоговорАвторскогоЗаказа => GetProperty<EnumItemBase>();
        public EnumItemBase ДоговорРаботыУслуги => GetProperty<EnumItemBase>();
        public EnumItemBase ДоходыКонтрагентов => GetProperty<EnumItemBase>();
        public EnumItemBase ДСВ => GetProperty<EnumItemBase>();
        public EnumItemBase МатериальнаяПомощь => GetProperty<EnumItemBase>();
        public EnumItemBase АлиментыПрочиеИсполнительныеЛисты => GetProperty<EnumItemBase>();
        public EnumItemBase ИсполнительныеЛисты => GetProperty<EnumItemBase>();
        public EnumItemBase ПочтовыйСбор => GetProperty<EnumItemBase>();
        public EnumItemBase ПогашениеЗаймов => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленоПроцентовПоЗайму => GetProperty<EnumItemBase>();
        public EnumItemBase ПроцентыПоЗайму => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочиеУдержания => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛДоначисленныйПоРезультатамПроверки => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛДоходыКонтрагентов => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛПередачаЗадолженностиВНалоговыйОрган => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛПрочиеРасчетыСПерсоналом => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛРасчетыСБывшимиСотрудниками => GetProperty<EnumItemBase>();
        public EnumItemBase НФДЛДивиденды => GetProperty<EnumItemBase>();
        public EnumItemBase НФДЛДивидендыСотрудникам => GetProperty<EnumItemBase>();
        public EnumItemBase ОценкаОбязательстваИФормированиеРезервов => GetProperty<EnumItemBase>();
        public EnumItemBase ДобровольныеВзносыВНПФ => GetProperty<EnumItemBase>();
        public EnumItemBase НачислениеЕСВРезерв => GetProperty<EnumItemBase>();
        public EnumItemBase Профвзносы => GetProperty<EnumItemBase>();
        public EnumItemBase НачислениеЕСВ => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>();
        public EnumItemBase Депонирование => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРДополнительныйТарифЛЭ => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРДополнительныйТарифШахтеры => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРЗаЗанятыхНаПодземныхИВредныхРаботах => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРНакопительнаяЧасть => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРСПревышения => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРДоПредельнойВеличины => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРПоСуммарномуТарифу => GetProperty<EnumItemBase>();
        public EnumItemBase ПФРСтраховаяЧасть => GetProperty<EnumItemBase>();
        public EnumItemBase РасходыПоСтрахованиюБюджет => GetProperty<EnumItemBase>();
        public EnumItemBase РасходыПоСтрахованиюРаботодатель => GetProperty<EnumItemBase>();
        public EnumItemBase РасходыПоСтрахованиюФСС => GetProperty<EnumItemBase>();
        public EnumItemBase РасходыПоСтрахованиюФССНС => GetProperty<EnumItemBase>();
        public EnumItemBase СписаниеДепонента => GetProperty<EnumItemBase>();
        public EnumItemBase ТФОМС => GetProperty<EnumItemBase>();
        public EnumItemBase УдержаниеЗаОтпуск => GetProperty<EnumItemBase>();
        public EnumItemBase УдержаниеНеизрасходованныхПодотчетныхСумм => GetProperty<EnumItemBase>();
        public EnumItemBase УдержаниеПоПрочимОперациямСРаботниками => GetProperty<EnumItemBase>();
        public EnumItemBase ФСС => GetProperty<EnumItemBase>();
        public EnumItemBase ФССНС => GetProperty<EnumItemBase>();
        public EnumItemBase ФФОМС => GetProperty<EnumItemBase>();
        public EnumItemBase ЕжегодныйОтпуск => GetProperty<EnumItemBase>();
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательства => GetProperty<EnumItemBase>();
        public EnumItemBase ПФР => GetProperty<EnumItemBase>();
        public EnumItemBase ФОМС => GetProperty<EnumItemBase>();
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательстваИРезервыБУ => GetProperty<EnumItemBase>();
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательстваИРезервыНУ => GetProperty<EnumItemBase>();
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательстваИРезервы => GetProperty<EnumItemBase>();
        public EnumItemBase ЕжегодныйОтпускРезервы => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсацияЕжегодногоОтпуска => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсацияЕжегодногоОтпускаОценочныеОбязательства => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочиеРасчетыСПерсоналом => GetProperty<EnumItemBase>();
        public EnumItemBase ВоенныйСбор => GetProperty<EnumItemBase>();
        public EnumItemBase ВСДоходыКонтрагентов => GetProperty<EnumItemBase>();
    }
}
