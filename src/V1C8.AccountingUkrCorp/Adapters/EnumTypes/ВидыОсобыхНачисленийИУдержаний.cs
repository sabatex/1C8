using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОсобыхНачисленийИУдержаний:EnumBase
    {
        public ВидыОсобыхНачисленийИУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Дивиденды => GetProperty<EnumItem>("Дивиденды");
        public EnumItem ДивидендыСотрудников => GetProperty<EnumItem>("ДивидендыСотрудников");
        public EnumItem ДоговорАвторскогоЗаказа => GetProperty<EnumItem>("ДоговорАвторскогоЗаказа");
        public EnumItem ДоговорРаботыУслуги => GetProperty<EnumItem>("ДоговорРаботыУслуги");
        public EnumItem ДСВРаботодателя => GetProperty<EnumItem>("ДСВРаботодателя");
        public EnumItem КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItem>("КомпенсацияЗаЗадержкуЗарплаты");
        public EnumItem МатериальнаяВыгодаПоЗаймам => GetProperty<EnumItem>("МатериальнаяВыгодаПоЗаймам");
        public EnumItem УдалитьМатериальнаяПомощь => GetProperty<EnumItem>("УдалитьМатериальнаяПомощь");
        public EnumItem НачисленоПроцентовПоЗайму => GetProperty<EnumItem>("НачисленоПроцентовПоЗайму");
        public EnumItem НДФЛ => GetProperty<EnumItem>("НДФЛ");
        public EnumItem НДФЛДоначисленныйПоРезультатамПроверки => GetProperty<EnumItem>("НДФЛДоначисленныйПоРезультатамПроверки");
        public EnumItem НДФЛДоходыКонтрагентов => GetProperty<EnumItem>("НДФЛДоходыКонтрагентов");
        public EnumItem НДФЛЗачтено => GetProperty<EnumItem>("НДФЛЗачтено");
        public EnumItem НДФЛКЗачету => GetProperty<EnumItem>("НДФЛКЗачету");
        public EnumItem НДФЛПередачаЗадолженностиВНалоговыйОрган => GetProperty<EnumItem>("НДФЛПередачаЗадолженностиВНалоговыйОрган");
        public EnumItem НДФЛПрочиеРасчетыСПерсоналом => GetProperty<EnumItem>("НДФЛПрочиеРасчетыСПерсоналом");
        public EnumItem НДФЛРасчетыСБывшимиСотрудниками => GetProperty<EnumItem>("НДФЛРасчетыСБывшимиСотрудниками");
        public EnumItem НФДЛДивиденды => GetProperty<EnumItem>("НФДЛДивиденды");
        public EnumItem НФДЛДивидендыСотрудникам => GetProperty<EnumItem>("НФДЛДивидендыСотрудникам");
        public EnumItem ПогашениеЗаймаИзЗарплаты => GetProperty<EnumItem>("ПогашениеЗаймаИзЗарплаты");
        public EnumItem ПособиеПриПостановкеНаУчетВРанниеСрокиБеременности => GetProperty<EnumItem>("ПособиеПриПостановкеНаУчетВРанниеСрокиБеременности");
        public EnumItem ПособиеПриРожденииРебенка => GetProperty<EnumItem>("ПособиеПриРожденииРебенка");
        public EnumItem ПроцентыПоЗайму => GetProperty<EnumItem>("ПроцентыПоЗайму");
        public EnumItem СтоимостьПодарковПризов => GetProperty<EnumItem>("СтоимостьПодарковПризов");
        public EnumItem ПособиеНаПогребение => GetProperty<EnumItem>("ПособиеНаПогребение");
        public EnumItem ВоенныйСбор => GetProperty<EnumItem>("ВоенныйСбор");
        public EnumItem ВСДоходыКонтрагентов => GetProperty<EnumItem>("ВСДоходыКонтрагентов");
    }
}
