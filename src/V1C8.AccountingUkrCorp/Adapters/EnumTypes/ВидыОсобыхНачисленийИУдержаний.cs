using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОсобыхНачисленийИУдержаний:V1C8COMObject
    {
        public ВидыОсобыхНачисленийИУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Дивиденды => GetProperty<EnumItemBase>("Дивиденды");
        public EnumItemBase ДивидендыСотрудников => GetProperty<EnumItemBase>("ДивидендыСотрудников");
        public EnumItemBase ДоговорАвторскогоЗаказа => GetProperty<EnumItemBase>("ДоговорАвторскогоЗаказа");
        public EnumItemBase ДоговорРаботыУслуги => GetProperty<EnumItemBase>("ДоговорРаботыУслуги");
        public EnumItemBase ДСВРаботодателя => GetProperty<EnumItemBase>("ДСВРаботодателя");
        public EnumItemBase КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItemBase>("КомпенсацияЗаЗадержкуЗарплаты");
        public EnumItemBase МатериальнаяВыгодаПоЗаймам => GetProperty<EnumItemBase>("МатериальнаяВыгодаПоЗаймам");
        public EnumItemBase УдалитьМатериальнаяПомощь => GetProperty<EnumItemBase>("УдалитьМатериальнаяПомощь");
        public EnumItemBase НачисленоПроцентовПоЗайму => GetProperty<EnumItemBase>("НачисленоПроцентовПоЗайму");
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>("НДФЛ");
        public EnumItemBase НДФЛДоначисленныйПоРезультатамПроверки => GetProperty<EnumItemBase>("НДФЛДоначисленныйПоРезультатамПроверки");
        public EnumItemBase НДФЛДоходыКонтрагентов => GetProperty<EnumItemBase>("НДФЛДоходыКонтрагентов");
        public EnumItemBase НДФЛЗачтено => GetProperty<EnumItemBase>("НДФЛЗачтено");
        public EnumItemBase НДФЛКЗачету => GetProperty<EnumItemBase>("НДФЛКЗачету");
        public EnumItemBase НДФЛПередачаЗадолженностиВНалоговыйОрган => GetProperty<EnumItemBase>("НДФЛПередачаЗадолженностиВНалоговыйОрган");
        public EnumItemBase НДФЛПрочиеРасчетыСПерсоналом => GetProperty<EnumItemBase>("НДФЛПрочиеРасчетыСПерсоналом");
        public EnumItemBase НДФЛРасчетыСБывшимиСотрудниками => GetProperty<EnumItemBase>("НДФЛРасчетыСБывшимиСотрудниками");
        public EnumItemBase НФДЛДивиденды => GetProperty<EnumItemBase>("НФДЛДивиденды");
        public EnumItemBase НФДЛДивидендыСотрудникам => GetProperty<EnumItemBase>("НФДЛДивидендыСотрудникам");
        public EnumItemBase ПогашениеЗаймаИзЗарплаты => GetProperty<EnumItemBase>("ПогашениеЗаймаИзЗарплаты");
        public EnumItemBase ПособиеПриПостановкеНаУчетВРанниеСрокиБеременности => GetProperty<EnumItemBase>("ПособиеПриПостановкеНаУчетВРанниеСрокиБеременности");
        public EnumItemBase ПособиеПриРожденииРебенка => GetProperty<EnumItemBase>("ПособиеПриРожденииРебенка");
        public EnumItemBase ПроцентыПоЗайму => GetProperty<EnumItemBase>("ПроцентыПоЗайму");
        public EnumItemBase СтоимостьПодарковПризов => GetProperty<EnumItemBase>("СтоимостьПодарковПризов");
        public EnumItemBase ПособиеНаПогребение => GetProperty<EnumItemBase>("ПособиеНаПогребение");
        public EnumItemBase ВоенныйСбор => GetProperty<EnumItemBase>("ВоенныйСбор");
        public EnumItemBase ВСДоходыКонтрагентов => GetProperty<EnumItemBase>("ВСДоходыКонтрагентов");
    }
}
