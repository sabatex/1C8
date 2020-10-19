using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОсобыхНачисленийИУдержаний:V1C8COMObject
    {
        public ВидыОсобыхНачисленийИУдержаний(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Дивиденды => GetProperty<EnumItemBase>();
        public EnumItemBase ДивидендыСотрудников => GetProperty<EnumItemBase>();
        public EnumItemBase ДоговорАвторскогоЗаказа => GetProperty<EnumItemBase>();
        public EnumItemBase ДоговорРаботыУслуги => GetProperty<EnumItemBase>();
        public EnumItemBase ДСВРаботодателя => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItemBase>();
        public EnumItemBase МатериальнаяВыгодаПоЗаймам => GetProperty<EnumItemBase>();
        public EnumItemBase УдалитьМатериальнаяПомощь => GetProperty<EnumItemBase>();
        public EnumItemBase НачисленоПроцентовПоЗайму => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛДоначисленныйПоРезультатамПроверки => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛДоходыКонтрагентов => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛЗачтено => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛКЗачету => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛПередачаЗадолженностиВНалоговыйОрган => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛПрочиеРасчетыСПерсоналом => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛРасчетыСБывшимиСотрудниками => GetProperty<EnumItemBase>();
        public EnumItemBase НФДЛДивиденды => GetProperty<EnumItemBase>();
        public EnumItemBase НФДЛДивидендыСотрудникам => GetProperty<EnumItemBase>();
        public EnumItemBase ПогашениеЗаймаИзЗарплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ПособиеПриПостановкеНаУчетВРанниеСрокиБеременности => GetProperty<EnumItemBase>();
        public EnumItemBase ПособиеПриРожденииРебенка => GetProperty<EnumItemBase>();
        public EnumItemBase ПроцентыПоЗайму => GetProperty<EnumItemBase>();
        public EnumItemBase СтоимостьПодарковПризов => GetProperty<EnumItemBase>();
        public EnumItemBase ПособиеНаПогребение => GetProperty<EnumItemBase>();
        public EnumItemBase ВоенныйСбор => GetProperty<EnumItemBase>();
        public EnumItemBase ВСДоходыКонтрагентов => GetProperty<EnumItemBase>();
    }
}
