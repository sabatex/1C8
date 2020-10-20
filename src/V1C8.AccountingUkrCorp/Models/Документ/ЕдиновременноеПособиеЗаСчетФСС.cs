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
    [Table("EdynovremennoePosobyeZaSchetFSS")]
    [Description1C8(Name = "ЕдиновременноеПособиеЗаСчетФСС", Comment = "", Synonym = "Единовременное пособие за счет ФСС")]
    public class ЕдиновременноеПособиеЗаСчетФСС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ВидПособия", Comment = "", Synonym = "Вид пособия")]
        public Enums.ПереченьПособийСоциальногоСтрахования ВидПособия {get; set;}
        [Description1C8(Name = "ДатаСобытия", Comment = "", Synonym = "Дата события")]
        public DateTime ДатаСобытия {get; set;}
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        // Format 13.2
        public decimal Начислено {get; set;}
        [Description1C8(Name = "ПорядокВыплаты", Comment = "", Synonym = "Порядок выплаты")]
        public Enums.ХарактерВыплатыЗарплаты ПорядокВыплаты {get; set;}
        [Description1C8(Name = "ПланируемаяДатаВыплаты", Comment = "", Synonym = "Планируемая дата выплаты")]
        public DateTime ПланируемаяДатаВыплаты {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ЕдиновременноеПособиеЗаСчетФСС ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ПредставлениеПериода", Comment = "", Synonym = "Представление периода")]
        [StringLength(19)]
        public string ПредставлениеПериода {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПособиеНаПогребениеСотруднику", Comment = "", Synonym = "Пособие на погребение сотруднику")]
        public bool ПособиеНаПогребениеСотруднику {get; set;}
        [Description1C8(Name = "ФондСоциальногоСтрахования", Comment = "", Synonym = "Фонд социального страхования")]
        public Enums.ВидыОбязательногоСтрахованияСотрудников ФондСоциальногоСтрахования {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФамилияУмершего", Comment = "", Synonym = "Фамилия умершего")]
        [StringLength(50)]
        public string ФамилияУмершего {get; set;}
        [Description1C8(Name = "ИмяУмершего", Comment = "ФамилияУмершего", Synonym = "Имя умершего")]
        [StringLength(50)]
        public string ИмяУмершего {get; set;}
        [Description1C8(Name = "ОтчествоУмершего", Comment = "", Synonym = "Отчество умершего")]
        [StringLength(50)]
        public string ОтчествоУмершего {get; set;}
        [Description1C8(Name = "СвидетельствоСерия", Comment = "", Synonym = "Свидетельство серия")]
        [StringLength(10)]
        public string СвидетельствоСерия {get; set;}
        [Description1C8(Name = "СвидетельствоНомер", Comment = "", Synonym = "Свидетельство номер")]
        [StringLength(10)]
        public string СвидетельствоНомер {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
