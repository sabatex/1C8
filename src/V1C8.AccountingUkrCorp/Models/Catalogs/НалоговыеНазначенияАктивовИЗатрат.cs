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
    [Table("NalohovyeNaznachenyiaAktyvovYZatrat")]
    [Description1C8(Name = "НалоговыеНазначенияАктивовИЗатрат", Comment = "(Регл)", Synonym = "Налоговые назначения активов и затрат")]
    public class НалоговыеНазначенияАктивовИЗатрат:EnumItem
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
    [Description1C8(Name = "ВидНалоговойДеятельности", Comment = "", Synonym = "Вид налоговой деятельности")]
    public DBNull ВидНалоговойДеятельности {get; set;}
    [Description1C8(Name = "Амортизируется", Comment = "", Synonym = "не используется - Амортизируется")]
    public bool Амортизируется {get; set;}
    [Description1C8(Name = "ВидДеятельностиНДС", Comment = "", Synonym = "Вид деятельности НДС")]
    public DBNull ВидДеятельностиНДС {get; set;}
    [Description1C8(Name = "Используется", Comment = "", Synonym = "Используется")]
    public bool Используется {get; set;}
    [Description1C8(Name = "ГруппаНалоговогоНазначения", Comment = "", Synonym = "Группа налогового назначения")]
    public DBNull ГруппаНалоговогоНазначения {get; set;}
    #endregion реквізити
    }
}
