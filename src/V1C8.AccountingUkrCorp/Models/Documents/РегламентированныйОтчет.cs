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
    [Table("RehlamentyrovannyiOtchet")]
    [Description1C8(Name = "РегламентированныйОтчет", Comment = "(Общ)", Synonym = "Регламентированный отчет")]
    public class РегламентированныйОтчет:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОтчетности", Comment = "(Общ)", Synonym = "Вид отчетности")]
        public Enums.ВидыОтчетности ВидОтчетности {get; set;}
        [Description1C8(Name = "ВыбраннаяФорма", Comment = "(Общ)", Synonym = "Выбранная форма")]
        public string ВыбраннаяФорма {get; set;}
        [Description1C8(Name = "ДанныеОтчета", Comment = "(Общ) Сохраненные данные отчета", Synonym = "Данные отчета")]
        // Сховище значень
        public byte[] ДанныеОтчета {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "(Общ)", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "(Общ)", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДатаПодписи", Comment = "(Общ) Дата подписи", Synonym = "Дата подписи")]
        public DateTime ДатаПодписи {get; set;}
        [Description1C8(Name = "ДеревоНастройкиСтраниц", Comment = "(Общ) Дерево со списком настроек страниц", Synonym = "Дерево настройки страниц")]
        // Сховище значень
        public byte[] ДеревоНастройкиСтраниц {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Enums.ПорядкиОкругленияОтчетности ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "ИсточникОтчета", Comment = "(Общ) Имя встроенной или имя файла внешней обработки", Synonym = "Источник отчета")]
        [StringLength(254)]
        public string ИсточникОтчета {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "НаименованиеОтчета", Comment = "(Общ) Наименование регламентированного отчета", Synonym = "Наименование отчета")]
        [StringLength(200)]
        public string НаименованиеОтчета {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        [StringLength(16)]
        public string Период {get; set;}
        [Description1C8(Name = "Периодичность", Comment = "(Общ) Периодичность представления отчета", Synonym = "Периодичность")]
        public Enums.Периодичность Периодичность {get; set;}
        [Description1C8(Name = "ФорматВыгрузки", Comment = "", Synonym = "Формат выгрузки")]
        [StringLength(30)]
        public string ФорматВыгрузки {get; set;}
        [Description1C8(Name = "ПредставлениеПериода", Comment = "", Synonym = "Представление периода")]
        [StringLength(50)]
        public string ПредставлениеПериода {get; set;}
        [Description1C8(Name = "ТочностьЕдиницыИзмерения", Comment = "(Общ)", Synonym = "Точность единицы измерения")]
        // Format 1.0
        public long ТочностьЕдиницыИзмерения {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
