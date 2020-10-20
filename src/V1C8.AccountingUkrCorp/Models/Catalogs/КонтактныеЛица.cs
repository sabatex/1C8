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
    [Table("KontaktnyeLytsa")]
    [Description1C8(Name = "КонтактныеЛица", Comment = "", Synonym = "Контактные лица")]
    public class КонтактныеЛица:CatalogItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "Фамилия", Comment = "", Synonym = "Фамилия")]
    [StringLength(50)]
    public string Фамилия {get; set;}
    [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
    [StringLength(50)]
    public string Имя {get; set;}
    [Description1C8(Name = "Отчество", Comment = "", Synonym = "Отчество")]
    [StringLength(50)]
    public string Отчество {get; set;}
    [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
    public DateTime ДатаРождения {get; set;}
    [Description1C8(Name = "Роль", Comment = "", Synonym = "Роль")]
    public Catalogs.РолиКонтактныхЛиц Роль {get; set;}
    [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
    [StringLength(100)]
    public string Должность {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "ОбъектВладелец", Comment = "", Synonym = "Объект владелец")]
    public Catalogs.Контрагенты ОбъектВладелец {get; set;}
    [Description1C8(Name = "ВидКонтактногоЛица", Comment = "", Synonym = "Вид контактного лица")]
    public Enums.ВидыКонтактныхЛиц ВидКонтактногоЛица {get; set;}
    [Description1C8(Name = "ПользовательЛичногоКонтакта", Comment = "", Synonym = "Пользователь личного контакта")]
    public Catalogs.Пользователи ПользовательЛичногоКонтакта {get; set;}
    #endregion реквізити
    }
}
