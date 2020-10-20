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
    [Table("VvodNachalnykhOstatkovOtpuskov")]
    [Description1C8(Name = "ВводНачальныхОстатковОтпусков", Comment = "", Synonym = "Ввод начальных остатков отпусков")]
    public class ВводНачальныхОстатковОтпусков:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ДатаОстатков", Comment = "", Synonym = "Дата остатков")]
        public DateTime ДатаОстатков {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
        public List<ВводНачальныхОстатковОтпусков_ЕжегодныеОтпуска> ВводНачальныхОстатковОтпусковЕжегодныеОтпуска {get;set;}
        [Description1C8(Name = "ОстаткиОтпусковПоРабочимГодам", Comment = "", Synonym = "Остатки отпусков по рабочим годам")]
        public List<ВводНачальныхОстатковОтпусков_ОстаткиОтпусковПоРабочимГодам> ВводНачальныхОстатковОтпусковОстаткиОтпусковПоРабочимГодам {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
    [Table("VvodNachalnykhOstatkovOtpuskov_EzhehodnyeOtpuska")]
    public class ВводНачальныхОстатковОтпусков_ЕжегодныеОтпуска
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидЕжегодногоОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидЕжегодногоОтпуска {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСЕжегоднымиОтпусками Действие {get; set;}
        [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
        // Format 2.0
        public long КоличествоДнейВГод {get; set;}
        [Description1C8(Name = "ОстатокНаДатуОстатков", Comment = "", Synonym = "Остаток")]
        // Format 5.2
        public decimal ОстатокНаДатуОстатков {get; set;}
        [Description1C8(Name = "УдалитьРабочийГодНачало", Comment = "", Synonym = "(не используется) Рабочий год с")]
        public DateTime УдалитьРабочийГодНачало {get; set;}
        [Description1C8(Name = "УдалитьРабочийГодОкончание", Comment = "", Synonym = "(не используется) Рабочий год по")]
        public DateTime УдалитьРабочийГодОкончание {get; set;}
    }
    [Description1C8(Name = "ОстаткиОтпусковПоРабочимГодам", Comment = "", Synonym = "Остатки отпусков по рабочим годам")]
    [Table("VvodNachalnykhOstatkovOtpuskov_OstatkyOtpuskovPoRabochymHodam")]
    public class ВводНачальныхОстатковОтпусков_ОстаткиОтпусковПоРабочимГодам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидЕжегодногоОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидЕжегодногоОтпуска {get; set;}
        [Description1C8(Name = "РабочийГодНачало", Comment = "", Synonym = "Рабочий год начало")]
        public DateTime РабочийГодНачало {get; set;}
        [Description1C8(Name = "РабочийГодОкончание", Comment = "", Synonym = "Рабочий год окончание")]
        public DateTime РабочийГодОкончание {get; set;}
        [Description1C8(Name = "Остаток", Comment = "", Synonym = "Остаток")]
        // Format 5.2
        public decimal Остаток {get; set;}
    }
}
