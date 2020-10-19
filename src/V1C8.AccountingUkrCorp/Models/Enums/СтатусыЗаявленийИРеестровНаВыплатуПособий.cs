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
    [Table("StatusyZaiavlenyiYReestrovNaVyplatuPosobyi")]
    [Description1C8(Name = "СтатусыЗаявленийИРеестровНаВыплатуПособий", Comment = "", Synonym = "Статусы заявлений и реестров на выплату пособий")]
    public class СтатусыЗаявленийИРеестровНаВыплатуПособий:EnumItem
    {
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий ВРаботе = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "ВРаботе",Synonym="В работе",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий Подготовлен = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "Подготовлен",Synonym="Подготовлен",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий ПереданВФСС = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "ПереданВФСС",Synonym="Передан в ФСС",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий ПринятФСС = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "ПринятФСС",Synonym="ѳ(не украинский) Принят ФСС",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий НеПринятФСС = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "НеПринятФСС",Synonym="ѳ(не украинский) Не принят ФСС",Comment=""};
        public static readonly СтатусыЗаявленийИРеестровНаВыплатуПособий Аннулирован = new СтатусыЗаявленийИРеестровНаВыплатуПособий{Name= "Аннулирован",Synonym="ѳ(не украинский) Аннулирован",Comment=""};
    }
}
