using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("VydyOperatsyiPKO")]
    [Description1C8(Name = "ВидыОперацийПКО", Comment = "(Общ)", Synonym = "Виды операций документа 'ПКО'")]
    public class ВидыОперацийПКО:EnumItem
    {
        public static readonly ВидыОперацийПКО ОплатаПокупателя = new ВидыОперацийПКО{Name= "ОплатаПокупателя",Synonym="Оплата от покупателя",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ПриходДенежныхСредствРозничнаяВыручка = new ВидыОперацийПКО{Name= "ПриходДенежныхСредствРозничнаяВыручка",Synonym="Розничная выручка",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ВозвратДенежныхСредствПодотчетником = new ВидыОперацийПКО{Name= "ВозвратДенежныхСредствПодотчетником",Synonym="Возврат от подотчетного лица",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ВозвратДенежныхСредствПоставщиком = new ВидыОперацийПКО{Name= "ВозвратДенежныхСредствПоставщиком",Synonym="Возврат от поставщика",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО ВозвратДенежныхСредствРаботником = new ВидыОперацийПКО{Name= "ВозвратДенежныхСредствРаботником",Synonym="Возврат денежных средств работником",Comment=""};
        public static readonly ВидыОперацийПКО ПолучениеНаличныхДенежныхСредствВБанке = new ВидыОперацийПКО{Name= "ПолучениеНаличныхДенежныхСредствВБанке",Synonym="Получение наличных в банке",Comment="(Общ)"};
        public static readonly ВидыОперацийПКО РасчетыПоКредитамИЗаймамСКонтрагентами = new ВидыОперацийПКО{Name= "РасчетыПоКредитамИЗаймамСКонтрагентами",Synonym="Расчеты по кредитам и займам",Comment=""};
        public static readonly ВидыОперацийПКО ПриходДенежныхСредствПрочее = new ВидыОперацийПКО{Name= "ПриходДенежныхСредствПрочее",Synonym="Прочий приход",Comment="(Общ)"};
    }
}
