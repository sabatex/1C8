using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийСписаниеДенежныхСредств", Comment = "", Synonym = "Виды операций списания денежных средств")]
    public enum ВидыОперацийСписаниеДенежныхСредств
    {
        [Description1C8(Name = "ОплатаПоставщику", Comment = "(Общ)", Synonym = "Оплата поставщику")]
        ОплатаПоставщику,
        [Description1C8(Name = "ВозвратДенежныхСредствПокупателю", Comment = "(Общ)", Synonym = "Возврат покупателю")]
        ВозвратДенежныхСредствПокупателю,
        [Description1C8(Name = "ПеречислениеНалога", Comment = "(Общ)", Synonym = "Перечисление налогов/взносов по заработной плате")]
        ПеречислениеНалога,
        [Description1C8(Name = "РасчетыПоКредитамИЗаймамСКонтрагентами", Comment = "", Synonym = "Расчеты по кредитам и займам")]
        РасчетыПоКредитамИЗаймамСКонтрагентами,
        [Description1C8(Name = "ПрочиеРасчетыСКонтрагентами", Comment = "", Synonym = "Прочие расчеты с контрагентами")]
        ПрочиеРасчетыСКонтрагентами,
        [Description1C8(Name = "ПереводНаДругойСчет", Comment = "", Synonym = "Перевод на другой счет организации")]
        ПереводНаДругойСчет,
        [Description1C8(Name = "ПеречислениеЗП", Comment = "(Общ)", Synonym = "Перечисление заработной платы")]
        ПеречислениеЗП,
        [Description1C8(Name = "ВыплатаЗарплатыНаЛицевыеСчета", Comment = "", Synonym = "Выплата зарплаты на лицевые счета")]
        ВыплатаЗарплатыНаЛицевыеСчета,
        [Description1C8(Name = "ПокупкаПродажаВалюты", Comment = "", Synonym = "Покупка/продажа валюты")]
        ПокупкаПродажаВалюты,
        [Description1C8(Name = "ПеречислениеДенежныхСредствПодотчетнику", Comment = "(Общ)", Synonym = "Перечисление подотчетному лицу")]
        ПеречислениеДенежныхСредствПодотчетнику,
        [Description1C8(Name = "ПрочееСписаниеБезналичныхДенежныхСредств", Comment = "", Synonym = "Прочее списание")]
        ПрочееСписаниеБезналичныхДенежныхСредств
    }
}
