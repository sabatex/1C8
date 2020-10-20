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
    [Table("ZakrytyeMesiatsa")]
    [Description1C8(Name = "ЗакрытиеМесяца", Comment = "", Synonym = "Закрытие месяца")]
    public class ЗакрытиеМесяца:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "АмортизацияНМА", Comment = "(Общ)", Synonym = "Начисление амортизации НМА")]
        public bool АмортизацияНМА {get; set;}
        [Description1C8(Name = "АмортизацияОС", Comment = "(Общ)", Synonym = "Начисление амортизации ОС")]
        public bool АмортизацияОС {get; set;}
        [Description1C8(Name = "ЗакрытиеНалоговыхРегистровНУ", Comment = "", Synonym = "Закрытие налоговых регистров (технологическая операция)")]
        public bool ЗакрытиеНалоговыхРегистровНУ {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КорректировкаСтоимостиНоменклатуры", Comment = "(Общ)", Synonym = "Корректировка стоимости номенклатуры")]
        public bool КорректировкаСтоимостиНоменклатуры {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ПереоценкаВалютныхСредств", Comment = "(Общ)", Synonym = "Переоценка валютных средств")]
        public bool ПереоценкаВалютныхСредств {get; set;}
        [Description1C8(Name = "ПереоценкаСтоимостиЗапасовБУ", Comment = "", Synonym = "Переоценка стоимости запасов (БУ)")]
        public bool ПереоценкаСтоимостиЗапасовБУ {get; set;}
        [Description1C8(Name = "РаспределениеТЗР", Comment = "", Synonym = "Распределение ТЗР")]
        public bool РаспределениеТЗР {get; set;}
        [Description1C8(Name = "РасчетСтоимостиПродукции", Comment = "(Общ)", Synonym = "Расчет и корректировка себестоимости продукции (услуг)")]
        public bool РасчетСтоимостиПродукции {get; set;}
        [Description1C8(Name = "РасчетТорговойНаценкиПоПроданнымТоварам", Comment = "", Synonym = "Расчет торговой наценки по проданным товарам")]
        public bool РасчетТорговойНаценкиПоПроданнымТоварам {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СписаниеРБП", Comment = "(Общ)", Synonym = "Списание расходов будущих периодов")]
        public bool СписаниеРБП {get; set;}
        [Description1C8(Name = "АмортизацияНМАНУ", Comment = "(Общ)", Synonym = "Начисление амортизации НМА (НУ)")]
        public bool АмортизацияНМАНУ {get; set;}
        [Description1C8(Name = "АмортизацияОСНУ", Comment = "(Общ)", Synonym = "Начисление амортизации ОС (НУ)")]
        public bool АмортизацияОСНУ {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
