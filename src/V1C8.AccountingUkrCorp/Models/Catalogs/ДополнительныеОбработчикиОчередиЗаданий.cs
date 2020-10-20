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
    [Table("DopolnytelnyeObrabotchykyOcheredyZadanyi")]
    [Description1C8(Name = "ДополнительныеОбработчикиОчередиЗаданий", Comment = "", Synonym = "Дополнительные обработчики очереди заданий")]
    public class ДополнительныеОбработчикиОчередиЗаданий:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "КоличествоЗаданий", Comment = "", Synonym = "Количество заданий")]
        // Format 2.0
        public long КоличествоЗаданий {get; set;}
        [Description1C8(Name = "ДлительностьЗадания", Comment = "", Synonym = "Длительность задания")]
        // Format 4.0
        public long ДлительностьЗадания {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Методы", Comment = "", Synonym = "Методы")]
        public List<ДополнительныеОбработчикиОчередиЗаданий_Методы> ДополнительныеОбработчикиОчередиЗаданийМетоды {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Методы", Comment = "", Synonym = "Методы")]
    [Table("DopolnytelnyeObrabotchykyOcheredyZadanyi_Metody")]
    public class ДополнительныеОбработчикиОчередиЗаданий_Методы
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Метод", Comment = "", Synonym = "Метод")]
        [StringLength(255)]
        public string Метод {get; set;}
    }
}
