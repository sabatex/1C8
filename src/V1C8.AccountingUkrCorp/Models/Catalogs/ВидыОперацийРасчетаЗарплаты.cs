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
    [Table("VydyOperatsyiRaschetaZarplaty")]
    [Description1C8(Name = "ВидыОперацийРасчетаЗарплаты", Comment = "", Synonym = "Виды операций расчета зарплаты")]
    public class ВидыОперацийРасчетаЗарплаты:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисления")]
    public bool Начисление {get; set;}
    [Description1C8(Name = "Договоры", Comment = "", Synonym = "Договоры")]
    public bool Договоры {get; set;}
    [Description1C8(Name = "Пособия", Comment = "", Synonym = "Пособия")]
    public bool Пособия {get; set;}
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    public bool Льготы {get; set;}
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    public bool Удержания {get; set;}
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    public bool НДФЛ {get; set;}
    [Description1C8(Name = "Займы", Comment = "", Synonym = "Займы")]
    public bool Займы {get; set;}
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    public bool ВзносыФОТ {get; set;}
    [Description1C8(Name = "ВАрхиве", Comment = "", Synonym = "В архиве")]
    public bool ВАрхиве {get; set;}
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    public bool Взносы {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
