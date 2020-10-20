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
    [Table("RehystrUcheta")]
    [Description1C8(Name = "РегистрУчета", Comment = "", Synonym = "Регистр учета")]
    public class РегистрУчета:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидРегистра", Comment = "", Synonym = "Вид регистра")]
        public Catalogs.ВидыРегистровУчета ВидРегистра {get; set;}
        [Description1C8(Name = "НачалоПериода", Comment = "", Synonym = "Начало периода")]
        public DateTime НачалоПериода {get; set;}
        [Description1C8(Name = "КонецПериода", Comment = "", Synonym = "Конец периода")]
        public DateTime КонецПериода {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ВключатьОбособленныеПодразделения", Comment = "", Synonym = "Включать обособленные подразделения")]
        public bool ВключатьОбособленныеПодразделения {get; set;}
        [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
        public string Описание {get; set;}
        [Description1C8(Name = "ФорматСохраненияФайла", Comment = "", Synonym = "Формат сохранения файла")]
        public Enums.ФорматыСохраненияОтчетов ФорматСохраненияФайла {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
