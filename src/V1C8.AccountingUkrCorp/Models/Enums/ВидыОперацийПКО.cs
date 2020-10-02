using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПКО", Comment = "(Общ)", Synonym = "Виды операций документа 'ПКО'")]
    public class ВидыОперацийПКО:EnumItem
    {
        public static readonly ВидыОперацийПКО ОплатаПокупателя = new ВидыОперацийПКО{Name= "ОплатаПокупателя",Synonim="Оплата от покупателя",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ПриходДенежныхСредствРозничнаяВыручка = new ВидыОперацийПКО{Name= "ПриходДенежныхСредствРозничнаяВыручка",Synonim="Розничная выручка",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ВозвратДенежныхСредствПодотчетником = new ВидыОперацийПКО{Name= "ВозвратДенежныхСредствПодотчетником",Synonim="Возврат от подотчетного лица",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ВозвратДенежныхСредствПоставщиком = new ВидыОперацийПКО{Name= "ВозвратДенежныхСредствПоставщиком",Synonim="Возврат от поставщика",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ВозвратДенежныхСредствРаботником = new ВидыОперацийПКО{Name= "ВозвратДенежныхСредствРаботником",Synonim="Возврат денежных средств работником",Comment=""};
        public static readonly ВидыОперацийПКО ПолучениеНаличныхДенежныхСредствВБанке = new ВидыОперацийПКО{Name= "ПолучениеНаличныхДенежныхСредствВБанке",Synonim="Получение наличных в банке",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО РасчетыПоКредитамИЗаймамСКонтрагентами = new ВидыОперацийПКО{Name= "РасчетыПоКредитамИЗаймамСКонтрагентами",Synonim="Расчеты по кредитам и займам",Comment=""};
        public static readonly ВидыОперацийПКО ПриходДенежныхСредствПрочее = new ВидыОперацийПКО{Name= "ПриходДенежныхСредствПрочее",Synonim="Прочий приход",Comment="(Общ)"};
    }
}
