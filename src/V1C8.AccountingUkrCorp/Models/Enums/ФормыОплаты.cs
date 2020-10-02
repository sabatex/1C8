using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФормыОплаты", Comment = "", Synonym = "Формы оплаты")]
    public class ФормыОплаты:EnumItem
    {
        public static readonly ФормыОплаты Наличная = new ФормыОплаты{Name= "Наличная",Synonim="Наличная",Comment=""};
        public static readonly ФормыОплаты Безналичная = new ФормыОплаты{Name= "Безналичная",Synonim="Безналичная",Comment=""};
        public static readonly ФормыОплаты ПлатежнаяКарта = new ФормыОплаты{Name= "ПлатежнаяКарта",Synonim="Платежная карта",Comment=""};
        public static readonly ФормыОплаты Взаимозачет = new ФормыОплаты{Name= "Взаимозачет",Synonim="Взаимозачет",Comment=""};
        public static readonly ФормыОплаты БонусныеБаллы = new ФормыОплаты{Name= "БонусныеБаллы",Synonim="Бонусные баллы",Comment=""};
        public static readonly ФормыОплаты ПодарочныйСертификат = new ФормыОплаты{Name= "ПодарочныйСертификат",Synonim="Подарочный сертификат",Comment=""};
    }
}
