using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("VyhruzkaRehlamentyrovannykhOtchetov")]
    [Description1C8(Name = "ВыгрузкаРегламентированныхОтчетов", Comment = "", Synonym = "Выгрузка регламентированных отчетов")]
    public class ВыгрузкаРегламентированныхОтчетов:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодС", Comment = "", Synonym = "Период С")]
        public DateTime ПериодС {get; set;}
        [Description1C8(Name = "ПериодПо", Comment = "", Synonym = "Период По")]
        public DateTime ПериодПо {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Дерево", Comment = "", Synonym = "Дерево")]
        // Сховище значень
        public byte[] Дерево {get; set;}
        [Description1C8(Name = "ВыгружаемыйОтчет", Comment = "", Synonym = "Выгружаемый отчет")]
        public string ВыгружаемыйОтчет {get; set;}
        [Description1C8(Name = "Основание", Comment = "", Synonym = "Основание")]
        public Documents.РегламентированныйОтчет Основание {get; set;}
        [Description1C8(Name = "C_DOC_CNT", Comment = "", Synonym = "Номер документа в периоде")]
        // Format 10.0
        public long C_DOC_CNT {get; set;}
        [Description1C8(Name = "C_DOC_TYPE", Comment = "", Synonym = "Номер исправленного документа")]
        // Format 10.0
        public long C_DOC_TYPE {get; set;}
        [Description1C8(Name = "ВыгружатьПакетом", Comment = "", Synonym = "Выгружать пакетом")]
        public bool ВыгружатьПакетом {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Выгрузки", Comment = "", Synonym = "Выгрузки")]
        public List<ВыгрузкаРегламентированныхОтчетов_Выгрузки> ВыгрузкаРегламентированныхОтчетовВыгрузки {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Выгрузки", Comment = "", Synonym = "Выгрузки")]
    [Table("VyhruzkaRehlamentyrovannykhOtchetov_Vyhruzky")]
    public class ВыгрузкаРегламентированныхОтчетов_Выгрузки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Тип", Comment = "", Synonym = "Тип")]
        public Enums.ВерсииФорматовВыгрузки Тип {get; set;}
        [Description1C8(Name = "ИмяФайла", Comment = "", Synonym = "Имя файла")]
        public string ИмяФайла {get; set;}
        [Description1C8(Name = "Текст", Comment = "", Synonym = "Текст")]
        public string Текст {get; set;}
        [Description1C8(Name = "фВыгрузка", Comment = "", Synonym = "Пометка о выгрузке")]
        public bool фВыгрузка {get; set;}
        [Description1C8(Name = "ИмяСхемы", Comment = "", Synonym = "Имя схемы выгрузки")]
        [StringLength(8)]
        public string ИмяСхемы {get; set;}
        [Description1C8(Name = "ПредставлениеСхемы", Comment = "", Synonym = "Представление схемы выгрузки")]
        public string ПредставлениеСхемы {get; set;}
        [Description1C8(Name = "НазваниеСтраницыПанели", Comment = "", Synonym = "Название страницы панели")]
        public string НазваниеСтраницыПанели {get; set;}
        [Description1C8(Name = "Префикс", Comment = "", Synonym = "Префикс")]
        [StringLength(10)]
        public string Префикс {get; set;}
        [Description1C8(Name = "Декларация", Comment = "", Synonym = "Декларация")]
        public bool Декларация {get; set;}
        [Description1C8(Name = "Приложение", Comment = "", Synonym = "Приложение")]
        public bool Приложение {get; set;}
    }
}
