using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПоЗарплате:V1C8COMObject
    {
        public ВидыОперацийПоЗарплате(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НачисленоДоход => GetProperty<EnumItemBase>("НачисленоДоход");
        public EnumItemBase НачисленоБольничные => GetProperty<EnumItemBase>("НачисленоБольничные");
        public EnumItemBase НачисленоОтпускныеДоход => GetProperty<EnumItemBase>("НачисленоОтпускныеДоход");
        public EnumItemBase НачисленоОтпускныеРезерв => GetProperty<EnumItemBase>("НачисленоОтпускныеРезерв");
        public EnumItemBase ВозвратИзлишнеВыплаченныхСуммВследствиеСчетныхОшибок => GetProperty<EnumItemBase>("ВозвратИзлишнеВыплаченныхСуммВследствиеСчетныхОшибок");
        public EnumItemBase ВозмещениеУщерба => GetProperty<EnumItemBase>("ВозмещениеУщерба");
        public EnumItemBase ВознаграждениеПлатежногоАгента => GetProperty<EnumItemBase>("ВознаграждениеПлатежногоАгента");
        public EnumItemBase ВыплатыБывшимСотрудникам => GetProperty<EnumItemBase>("ВыплатыБывшимСотрудникам");
        public EnumItemBase НатуральныйДоход => GetProperty<EnumItemBase>("НатуральныйДоход");
        public EnumItemBase Дивиденды => GetProperty<EnumItemBase>("Дивиденды");
        public EnumItemBase НачисленоСдельноДоход => GetProperty<EnumItemBase>("НачисленоСдельноДоход");
        public EnumItemBase НачисленоЗаСчетФССДоход => GetProperty<EnumItemBase>("НачисленоЗаСчетФССДоход");
        public EnumItemBase ДивидендыСотрудников => GetProperty<EnumItemBase>("ДивидендыСотрудников");
        public EnumItemBase ДоговорАвторскогоЗаказа => GetProperty<EnumItemBase>("ДоговорАвторскогоЗаказа");
        public EnumItemBase ДоговорРаботыУслуги => GetProperty<EnumItemBase>("ДоговорРаботыУслуги");
        public EnumItemBase ДоходыКонтрагентов => GetProperty<EnumItemBase>("ДоходыКонтрагентов");
        public EnumItemBase ДСВ => GetProperty<EnumItemBase>("ДСВ");
        public EnumItemBase МатериальнаяПомощь => GetProperty<EnumItemBase>("МатериальнаяПомощь");
        public EnumItemBase АлиментыПрочиеИсполнительныеЛисты => GetProperty<EnumItemBase>("АлиментыПрочиеИсполнительныеЛисты");
        public EnumItemBase ИсполнительныеЛисты => GetProperty<EnumItemBase>("ИсполнительныеЛисты");
        public EnumItemBase ПочтовыйСбор => GetProperty<EnumItemBase>("ПочтовыйСбор");
        public EnumItemBase ПогашениеЗаймов => GetProperty<EnumItemBase>("ПогашениеЗаймов");
        public EnumItemBase НачисленоПроцентовПоЗайму => GetProperty<EnumItemBase>("НачисленоПроцентовПоЗайму");
        public EnumItemBase ПроцентыПоЗайму => GetProperty<EnumItemBase>("ПроцентыПоЗайму");
        public EnumItemBase КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItemBase>("КомпенсацияЗаЗадержкуЗарплаты");
        public EnumItemBase ПрочиеУдержания => GetProperty<EnumItemBase>("ПрочиеУдержания");
        public EnumItemBase НДФЛДоначисленныйПоРезультатамПроверки => GetProperty<EnumItemBase>("НДФЛДоначисленныйПоРезультатамПроверки");
        public EnumItemBase НДФЛДоходыКонтрагентов => GetProperty<EnumItemBase>("НДФЛДоходыКонтрагентов");
        public EnumItemBase НДФЛПередачаЗадолженностиВНалоговыйОрган => GetProperty<EnumItemBase>("НДФЛПередачаЗадолженностиВНалоговыйОрган");
        public EnumItemBase НДФЛПрочиеРасчетыСПерсоналом => GetProperty<EnumItemBase>("НДФЛПрочиеРасчетыСПерсоналом");
        public EnumItemBase НДФЛРасчетыСБывшимиСотрудниками => GetProperty<EnumItemBase>("НДФЛРасчетыСБывшимиСотрудниками");
        public EnumItemBase НФДЛДивиденды => GetProperty<EnumItemBase>("НФДЛДивиденды");
        public EnumItemBase НФДЛДивидендыСотрудникам => GetProperty<EnumItemBase>("НФДЛДивидендыСотрудникам");
        public EnumItemBase ОценкаОбязательстваИФормированиеРезервов => GetProperty<EnumItemBase>("ОценкаОбязательстваИФормированиеРезервов");
        public EnumItemBase ДобровольныеВзносыВНПФ => GetProperty<EnumItemBase>("ДобровольныеВзносыВНПФ");
        public EnumItemBase НачислениеЕСВРезерв => GetProperty<EnumItemBase>("НачислениеЕСВРезерв");
        public EnumItemBase Профвзносы => GetProperty<EnumItemBase>("Профвзносы");
        public EnumItemBase НачислениеЕСВ => GetProperty<EnumItemBase>("НачислениеЕСВ");
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>("НДФЛ");
        public EnumItemBase Депонирование => GetProperty<EnumItemBase>("Депонирование");
        public EnumItemBase ПФРДополнительныйТарифЛЭ => GetProperty<EnumItemBase>("ПФРДополнительныйТарифЛЭ");
        public EnumItemBase ПФРДополнительныйТарифШахтеры => GetProperty<EnumItemBase>("ПФРДополнительныйТарифШахтеры");
        public EnumItemBase ПФРЗаЗанятыхНаПодземныхИВредныхРаботах => GetProperty<EnumItemBase>("ПФРЗаЗанятыхНаПодземныхИВредныхРаботах");
        public EnumItemBase ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах => GetProperty<EnumItemBase>("ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах");
        public EnumItemBase ПФРНакопительнаяЧасть => GetProperty<EnumItemBase>("ПФРНакопительнаяЧасть");
        public EnumItemBase ПФРСПревышения => GetProperty<EnumItemBase>("ПФРСПревышения");
        public EnumItemBase ПФРДоПредельнойВеличины => GetProperty<EnumItemBase>("ПФРДоПредельнойВеличины");
        public EnumItemBase ПФРПоСуммарномуТарифу => GetProperty<EnumItemBase>("ПФРПоСуммарномуТарифу");
        public EnumItemBase ПФРСтраховаяЧасть => GetProperty<EnumItemBase>("ПФРСтраховаяЧасть");
        public EnumItemBase РасходыПоСтрахованиюБюджет => GetProperty<EnumItemBase>("РасходыПоСтрахованиюБюджет");
        public EnumItemBase РасходыПоСтрахованиюРаботодатель => GetProperty<EnumItemBase>("РасходыПоСтрахованиюРаботодатель");
        public EnumItemBase РасходыПоСтрахованиюФСС => GetProperty<EnumItemBase>("РасходыПоСтрахованиюФСС");
        public EnumItemBase РасходыПоСтрахованиюФССНС => GetProperty<EnumItemBase>("РасходыПоСтрахованиюФССНС");
        public EnumItemBase СписаниеДепонента => GetProperty<EnumItemBase>("СписаниеДепонента");
        public EnumItemBase ТФОМС => GetProperty<EnumItemBase>("ТФОМС");
        public EnumItemBase УдержаниеЗаОтпуск => GetProperty<EnumItemBase>("УдержаниеЗаОтпуск");
        public EnumItemBase УдержаниеНеизрасходованныхПодотчетныхСумм => GetProperty<EnumItemBase>("УдержаниеНеизрасходованныхПодотчетныхСумм");
        public EnumItemBase УдержаниеПоПрочимОперациямСРаботниками => GetProperty<EnumItemBase>("УдержаниеПоПрочимОперациямСРаботниками");
        public EnumItemBase ФСС => GetProperty<EnumItemBase>("ФСС");
        public EnumItemBase ФССНС => GetProperty<EnumItemBase>("ФССНС");
        public EnumItemBase ФФОМС => GetProperty<EnumItemBase>("ФФОМС");
        public EnumItemBase ЕжегодныйОтпуск => GetProperty<EnumItemBase>("ЕжегодныйОтпуск");
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательства => GetProperty<EnumItemBase>("ЕжегодныйОтпускОценочныеОбязательства");
        public EnumItemBase ПФР => GetProperty<EnumItemBase>("ПФР");
        public EnumItemBase ФОМС => GetProperty<EnumItemBase>("ФОМС");
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательстваИРезервыБУ => GetProperty<EnumItemBase>("ЕжегодныйОтпускОценочныеОбязательстваИРезервыБУ");
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательстваИРезервыНУ => GetProperty<EnumItemBase>("ЕжегодныйОтпускОценочныеОбязательстваИРезервыНУ");
        public EnumItemBase ЕжегодныйОтпускОценочныеОбязательстваИРезервы => GetProperty<EnumItemBase>("ЕжегодныйОтпускОценочныеОбязательстваИРезервы");
        public EnumItemBase ЕжегодныйОтпускРезервы => GetProperty<EnumItemBase>("ЕжегодныйОтпускРезервы");
        public EnumItemBase КомпенсацияЕжегодногоОтпуска => GetProperty<EnumItemBase>("КомпенсацияЕжегодногоОтпуска");
        public EnumItemBase КомпенсацияЕжегодногоОтпускаОценочныеОбязательства => GetProperty<EnumItemBase>("КомпенсацияЕжегодногоОтпускаОценочныеОбязательства");
        public EnumItemBase ПрочиеРасчетыСПерсоналом => GetProperty<EnumItemBase>("ПрочиеРасчетыСПерсоналом");
        public EnumItemBase ВоенныйСбор => GetProperty<EnumItemBase>("ВоенныйСбор");
        public EnumItemBase ВСДоходыКонтрагентов => GetProperty<EnumItemBase>("ВСДоходыКонтрагентов");
    }
}
