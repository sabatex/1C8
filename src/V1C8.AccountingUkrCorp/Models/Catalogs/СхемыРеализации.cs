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
    [Table("SkhemyRealyzatsyy")]
    [Description1C8(Name = "СхемыРеализации", Comment = "(Регл)", Synonym = "Схемы реализации")]
    public class СхемыРеализации:CatalogItem
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
    [Description1C8(Name = "СчетДоходов", Comment = "", Synonym = "Счет доходов")]
    public ПланСчетов.Хозрасчетный СчетДоходов {get; set;}
    [Description1C8(Name = "СубконтоДоходов1", Comment = "", Synonym = "Субконто доходов1")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов1 {get; set;}
    [Description1C8(Name = "СубконтоДоходов2", Comment = "", Synonym = "Субконто доходов 2")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов2 {get; set;}
    [Description1C8(Name = "СубконтоДоходов3", Comment = "", Synonym = "Субконто доходов 3")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов3 {get; set;}
    [Description1C8(Name = "СчетСебестоимости", Comment = "", Synonym = "Счет себестоимости")]
    public ПланСчетов.Хозрасчетный СчетСебестоимости {get; set;}
    [Description1C8(Name = "СубконтоСебестоимости1", Comment = "", Synonym = "Субконто себестоимости1")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоСебестоимости1 {get; set;}
    [Description1C8(Name = "СубконтоСебестоимости2", Comment = "", Synonym = "Субконто себестоимости1")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоСебестоимости2 {get; set;}
    [Description1C8(Name = "СубконтоСебестоимости3", Comment = "", Synonym = "Субконто себестоимости1")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоСебестоимости3 {get; set;}
    [Description1C8(Name = "СчетВычетовИзДоходов", Comment = "", Synonym = "Счет вычетов из доходов")]
    public ПланСчетов.Хозрасчетный СчетВычетовИзДоходов {get; set;}
    [Description1C8(Name = "СубконтоВычетовИзДоходов1", Comment = "", Synonym = "Субконто вычетов из доходов1")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоВычетовИзДоходов1 {get; set;}
    [Description1C8(Name = "СубконтоВычетовИзДоходов2", Comment = "", Synonym = "Субконто вычетов из доходов2")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоВычетовИзДоходов2 {get; set;}
    [Description1C8(Name = "СубконтоВычетовИзДоходов3", Comment = "", Synonym = "Субконто вычетов из доходов3")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоВычетовИзДоходов3 {get; set;}
    [Description1C8(Name = "СчетСебестоимостиПриВозврате", Comment = "", Synonym = "Счет себестоимости при возврате")]
    public ПланСчетов.Хозрасчетный СчетСебестоимостиПриВозврате {get; set;}
    [Description1C8(Name = "СубконтоСебестоимостиПриВозврате1", Comment = "", Synonym = "Субконто себестоимости при возврате")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоСебестоимостиПриВозврате1 {get; set;}
    [Description1C8(Name = "СубконтоСебестоимостиПриВозврате2", Comment = "", Synonym = "Субконто себестоимости при возврате")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоСебестоимостиПриВозврате2 {get; set;}
    [Description1C8(Name = "СубконтоСебестоимостиПриВозврате3", Comment = "", Synonym = "Субконто себестоимости при возврате")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоСебестоимостиПриВозврате3 {get; set;}
    #endregion реквізити
    }
}
