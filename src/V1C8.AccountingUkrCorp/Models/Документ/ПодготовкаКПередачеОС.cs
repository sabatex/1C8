using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("PodhotovkaKPeredacheOS")]
    [Description1C8(Name = "ПодготовкаКПередачеОС", Comment = "(Общ)", Synonym = "Подготовка к передаче ОС")]
    public class ПодготовкаКПередачеОС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Общ)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СписыватьСуммуДооценокНаНераспределеннуюПрибыль", Comment = "", Synonym = "Списывать сумму дооценок на нераспределенную прибыль")]
        public bool СписыватьСуммуДооценокНаНераспределеннуюПрибыль {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<ПодготовкаКПередачеОС_ОС> ПодготовкаКПередачеОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("PodhotovkaKPeredacheOS_OS")]
    public class ПодготовкаКПередачеОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "АмортизацияБУ", Comment = "(Регл)", Synonym = "Амортизация (БУ)")]
        // Format 15.2
        public decimal АмортизацияБУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцБУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (БУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцБУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииНУ", Comment = "(Регл)", Synonym = "")]
        // Format 15.2
        public decimal СуммаМодернизацииНУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцНУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (НУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцНУ {get; set;}
        [Description1C8(Name = "СчетПродажиОС", Comment = "(Регл)", Synonym = "Счет продажи ОС")]
        public ПланСчетов.Хозрасчетный СчетПродажиОС {get; set;}
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "ПревышениеСуммДооценокНадСуммамиУценокБУ", Comment = "", Synonym = "Превышение сумм дооценок над суммами уценок (БУ)")]
        // Format 15.2
        public decimal ПревышениеСуммДооценокНадСуммамиУценокБУ {get; set;}
    }
}
