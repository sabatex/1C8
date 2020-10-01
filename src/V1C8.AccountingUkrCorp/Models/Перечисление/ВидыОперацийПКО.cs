using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПКО", Comment = "(Общ)", Synonym = "Виды операций документа 'ПКО'")]
    public enum ВидыОперацийПКО
    {
        [Description1C8(Name = "ОплатаПокупателя", Comment = "(Общ)", Synonym = "Оплата от покупателя")]
        ОплатаПокупателя,
        [Description1C8(Name = "ПриходДенежныхСредствРозничнаяВыручка", Comment = "(Общ)", Synonym = "Розничная выручка")]
        ПриходДенежныхСредствРозничнаяВыручка,
        [Description1C8(Name = "ВозвратДенежныхСредствПодотчетником", Comment = "(Общ)", Synonym = "Возврат от подотчетного лица")]
        ВозвратДенежныхСредствПодотчетником,
        [Description1C8(Name = "ВозвратДенежныхСредствПоставщиком", Comment = "(Общ)", Synonym = "Возврат от поставщика")]
        ВозвратДенежныхСредствПоставщиком,
        [Description1C8(Name = "ВозвратДенежныхСредствРаботником", Comment = "", Synonym = "Возврат денежных средств работником")]
        ВозвратДенежныхСредствРаботником,
        [Description1C8(Name = "ПолучениеНаличныхДенежныхСредствВБанке", Comment = "(Общ)", Synonym = "Получение наличных в банке")]
        ПолучениеНаличныхДенежныхСредствВБанке,
        [Description1C8(Name = "РасчетыПоКредитамИЗаймамСКонтрагентами", Comment = "", Synonym = "Расчеты по кредитам и займам")]
        РасчетыПоКредитамИЗаймамСКонтрагентами,
        [Description1C8(Name = "ПриходДенежныхСредствПрочее", Comment = "(Общ)", Synonym = "Прочий приход")]
        ПриходДенежныхСредствПрочее
    }
}
