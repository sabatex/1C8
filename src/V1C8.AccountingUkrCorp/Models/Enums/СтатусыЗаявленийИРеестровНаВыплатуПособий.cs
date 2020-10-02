using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыЗаявленийИРеестровНаВыплатуПособий", Comment = "", Synonym = "Статусы заявлений и реестров на выплату пособий")]
    public class СтатусыЗаявленийИРеестровНаВыплатуПособий:EnumItem
    {
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий ВРаботе = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "ВРаботе",Synonim="В работе",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий Подготовлен = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "Подготовлен",Synonim="Подготовлен",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий ПереданВФСС = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "ПереданВФСС",Synonim="Передан в ФСС",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий ПринятФСС = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "ПринятФСС",Synonim="ѳ(не украинский) Принят ФСС",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий НеПринятФСС = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "НеПринятФСС",Synonim="ѳ(не украинский) Не принят ФСС",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий Аннулирован = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "Аннулирован",Synonim="ѳ(не украинский) Аннулирован",Comment=""};
    }
}
