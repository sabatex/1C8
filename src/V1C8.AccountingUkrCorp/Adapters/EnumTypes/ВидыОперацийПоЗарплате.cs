using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПоЗарплате:EnumBase
    {
        public ВидыОперацийПоЗарплате(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НачисленоДоход => GetProperty<EnumItem>("НачисленоДоход");
        public EnumItem НачисленоБольничные => GetProperty<EnumItem>("НачисленоБольничные");
        public EnumItem НачисленоОтпускныеДоход => GetProperty<EnumItem>("НачисленоОтпускныеДоход");
        public EnumItem НачисленоОтпускныеРезерв => GetProperty<EnumItem>("НачисленоОтпускныеРезерв");
        public EnumItem ВозвратИзлишнеВыплаченныхСуммВследствиеСчетныхОшибок => GetProperty<EnumItem>("ВозвратИзлишнеВыплаченныхСуммВследствиеСчетныхОшибок");
        public EnumItem ВозмещениеУщерба => GetProperty<EnumItem>("ВозмещениеУщерба");
        public EnumItem ВознаграждениеПлатежногоАгента => GetProperty<EnumItem>("ВознаграждениеПлатежногоАгента");
        public EnumItem ВыплатыБывшимСотрудникам => GetProperty<EnumItem>("ВыплатыБывшимСотрудникам");
        public EnumItem НатуральныйДоход => GetProperty<EnumItem>("НатуральныйДоход");
        public EnumItem Дивиденды => GetProperty<EnumItem>("Дивиденды");
        public EnumItem НачисленоСдельноДоход => GetProperty<EnumItem>("НачисленоСдельноДоход");
        public EnumItem НачисленоЗаСчетФССДоход => GetProperty<EnumItem>("НачисленоЗаСчетФССДоход");
        public EnumItem ДивидендыСотрудников => GetProperty<EnumItem>("ДивидендыСотрудников");
        public EnumItem ДоговорАвторскогоЗаказа => GetProperty<EnumItem>("ДоговорАвторскогоЗаказа");
        public EnumItem ДоговорРаботыУслуги => GetProperty<EnumItem>("ДоговорРаботыУслуги");
        public EnumItem ДоходыКонтрагентов => GetProperty<EnumItem>("ДоходыКонтрагентов");
        public EnumItem ДСВ => GetProperty<EnumItem>("ДСВ");
        public EnumItem МатериальнаяПомощь => GetProperty<EnumItem>("МатериальнаяПомощь");
        public EnumItem АлиментыПрочиеИсполнительныеЛисты => GetProperty<EnumItem>("АлиментыПрочиеИсполнительныеЛисты");
        public EnumItem ИсполнительныеЛисты => GetProperty<EnumItem>("ИсполнительныеЛисты");
        public EnumItem ПочтовыйСбор => GetProperty<EnumItem>("ПочтовыйСбор");
        public EnumItem ПогашениеЗаймов => GetProperty<EnumItem>("ПогашениеЗаймов");
        public EnumItem НачисленоПроцентовПоЗайму => GetProperty<EnumItem>("НачисленоПроцентовПоЗайму");
        public EnumItem ПроцентыПоЗайму => GetProperty<EnumItem>("ПроцентыПоЗайму");
        public EnumItem КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItem>("КомпенсацияЗаЗадержкуЗарплаты");
        public EnumItem ПрочиеУдержания => GetProperty<EnumItem>("ПрочиеУдержания");
        public EnumItem НДФЛДоначисленныйПоРезультатамПроверки => GetProperty<EnumItem>("НДФЛДоначисленныйПоРезультатамПроверки");
        public EnumItem НДФЛДоходыКонтрагентов => GetProperty<EnumItem>("НДФЛДоходыКонтрагентов");
        public EnumItem НДФЛПередачаЗадолженностиВНалоговыйОрган => GetProperty<EnumItem>("НДФЛПередачаЗадолженностиВНалоговыйОрган");
        public EnumItem НДФЛПрочиеРасчетыСПерсоналом => GetProperty<EnumItem>("НДФЛПрочиеРасчетыСПерсоналом");
        public EnumItem НДФЛРасчетыСБывшимиСотрудниками => GetProperty<EnumItem>("НДФЛРасчетыСБывшимиСотрудниками");
        public EnumItem НФДЛДивиденды => GetProperty<EnumItem>("НФДЛДивиденды");
        public EnumItem НФДЛДивидендыСотрудникам => GetProperty<EnumItem>("НФДЛДивидендыСотрудникам");
        public EnumItem ОценкаОбязательстваИФормированиеРезервов => GetProperty<EnumItem>("ОценкаОбязательстваИФормированиеРезервов");
        public EnumItem ДобровольныеВзносыВНПФ => GetProperty<EnumItem>("ДобровольныеВзносыВНПФ");
        public EnumItem НачислениеЕСВРезерв => GetProperty<EnumItem>("НачислениеЕСВРезерв");
        public EnumItem Профвзносы => GetProperty<EnumItem>("Профвзносы");
        public EnumItem НачислениеЕСВ => GetProperty<EnumItem>("НачислениеЕСВ");
        public EnumItem НДФЛ => GetProperty<EnumItem>("НДФЛ");
        public EnumItem Депонирование => GetProperty<EnumItem>("Депонирование");
        public EnumItem ПФРДополнительныйТарифЛЭ => GetProperty<EnumItem>("ПФРДополнительныйТарифЛЭ");
        public EnumItem ПФРДополнительныйТарифШахтеры => GetProperty<EnumItem>("ПФРДополнительныйТарифШахтеры");
        public EnumItem ПФРЗаЗанятыхНаПодземныхИВредныхРаботах => GetProperty<EnumItem>("ПФРЗаЗанятыхНаПодземныхИВредныхРаботах");
        public EnumItem ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах => GetProperty<EnumItem>("ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах");
        public EnumItem ПФРНакопительнаяЧасть => GetProperty<EnumItem>("ПФРНакопительнаяЧасть");
        public EnumItem ПФРСПревышения => GetProperty<EnumItem>("ПФРСПревышения");
        public EnumItem ПФРДоПредельнойВеличины => GetProperty<EnumItem>("ПФРДоПредельнойВеличины");
        public EnumItem ПФРПоСуммарномуТарифу => GetProperty<EnumItem>("ПФРПоСуммарномуТарифу");
        public EnumItem ПФРСтраховаяЧасть => GetProperty<EnumItem>("ПФРСтраховаяЧасть");
        public EnumItem РасходыПоСтрахованиюБюджет => GetProperty<EnumItem>("РасходыПоСтрахованиюБюджет");
        public EnumItem РасходыПоСтрахованиюРаботодатель => GetProperty<EnumItem>("РасходыПоСтрахованиюРаботодатель");
        public EnumItem РасходыПоСтрахованиюФСС => GetProperty<EnumItem>("РасходыПоСтрахованиюФСС");
        public EnumItem РасходыПоСтрахованиюФССНС => GetProperty<EnumItem>("РасходыПоСтрахованиюФССНС");
        public EnumItem СписаниеДепонента => GetProperty<EnumItem>("СписаниеДепонента");
        public EnumItem ТФОМС => GetProperty<EnumItem>("ТФОМС");
        public EnumItem УдержаниеЗаОтпуск => GetProperty<EnumItem>("УдержаниеЗаОтпуск");
        public EnumItem УдержаниеНеизрасходованныхПодотчетныхСумм => GetProperty<EnumItem>("УдержаниеНеизрасходованныхПодотчетныхСумм");
        public EnumItem УдержаниеПоПрочимОперациямСРаботниками => GetProperty<EnumItem>("УдержаниеПоПрочимОперациямСРаботниками");
        public EnumItem ФСС => GetProperty<EnumItem>("ФСС");
        public EnumItem ФССНС => GetProperty<EnumItem>("ФССНС");
        public EnumItem ФФОМС => GetProperty<EnumItem>("ФФОМС");
        public EnumItem ЕжегодныйОтпуск => GetProperty<EnumItem>("ЕжегодныйОтпуск");
        public EnumItem ЕжегодныйОтпускОценочныеОбязательства => GetProperty<EnumItem>("ЕжегодныйОтпускОценочныеОбязательства");
        public EnumItem ПФР => GetProperty<EnumItem>("ПФР");
        public EnumItem ФОМС => GetProperty<EnumItem>("ФОМС");
        public EnumItem ЕжегодныйОтпускОценочныеОбязательстваИРезервыБУ => GetProperty<EnumItem>("ЕжегодныйОтпускОценочныеОбязательстваИРезервыБУ");
        public EnumItem ЕжегодныйОтпускОценочныеОбязательстваИРезервыНУ => GetProperty<EnumItem>("ЕжегодныйОтпускОценочныеОбязательстваИРезервыНУ");
        public EnumItem ЕжегодныйОтпускОценочныеОбязательстваИРезервы => GetProperty<EnumItem>("ЕжегодныйОтпускОценочныеОбязательстваИРезервы");
        public EnumItem ЕжегодныйОтпускРезервы => GetProperty<EnumItem>("ЕжегодныйОтпускРезервы");
        public EnumItem КомпенсацияЕжегодногоОтпуска => GetProperty<EnumItem>("КомпенсацияЕжегодногоОтпуска");
        public EnumItem КомпенсацияЕжегодногоОтпускаОценочныеОбязательства => GetProperty<EnumItem>("КомпенсацияЕжегодногоОтпускаОценочныеОбязательства");
        public EnumItem ПрочиеРасчетыСПерсоналом => GetProperty<EnumItem>("ПрочиеРасчетыСПерсоналом");
        public EnumItem ВоенныйСбор => GetProperty<EnumItem>("ВоенныйСбор");
        public EnumItem ВСДоходыКонтрагентов => GetProperty<EnumItem>("ВСДоходыКонтрагентов");
    }
}
