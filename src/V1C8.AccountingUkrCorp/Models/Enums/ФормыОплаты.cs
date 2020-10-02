using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФормыОплаты", Comment = "", Synonym = "Формы оплаты")]
    public class ФормыОплаты:EnumItem
    {
        public static readonly ФормыОплаты Наличная = new ФормыОплаты{Name= "Наличная",Synonym="Наличная",Comment=""};
        public static readonly ФормыОплаты Безналичная = new ФормыОплаты{Name= "Безналичная",Synonym="Безналичная",Comment=""};
        public static readonly ФормыОплаты ПлатежнаяКарта = new ФормыОплаты{Name= "ПлатежнаяКарта",Synonym="Платежная карта",Comment=""};
        public static readonly ФормыОплаты Взаимозачет = new ФормыОплаты{Name= "Взаимозачет",Synonym="Взаимозачет",Comment=""};
        public static readonly ФормыОплаты БонусныеБаллы = new ФормыОплаты{Name= "БонусныеБаллы",Synonym="Бонусные баллы",Comment=""};
        public static readonly ФормыОплаты ПодарочныйСертификат = new ФормыОплаты{Name= "ПодарочныйСертификат",Synonym="Подарочный сертификат",Comment=""};
    }
}
