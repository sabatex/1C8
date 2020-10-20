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
    [Table("VydyKontaktnoiYnformatsyy")]
    [Description1C8(Name = "ВидыКонтактнойИнформации", Comment = "", Synonym = "Виды контактной информации")]
    public class ВидыКонтактнойИнформации:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ТолькоНациональныйАдрес", Comment = "", Synonym = "Только национальный адрес")]
        public bool ТолькоНациональныйАдрес {get; set;}
        [Description1C8(Name = "МожноИзменятьСпособРедактирования", Comment = "", Synonym = "Можно изменять способ редактирования")]
        public bool МожноИзменятьСпособРедактирования {get; set;}
        [Description1C8(Name = "ПроверятьКорректность", Comment = "", Synonym = "Запрещать ввод некорректного адреса")]
        public bool ПроверятьКорректность {get; set;}
        [Description1C8(Name = "ОбязательноеЗаполнение", Comment = "", Synonym = "Обязательное заполнение")]
        public bool ОбязательноеЗаполнение {get; set;}
        [Description1C8(Name = "Используется", Comment = "", Synonym = "Используется")]
        public bool Используется {get; set;}
        [Description1C8(Name = "ЗапретитьРедактированиеПользователем", Comment = "", Synonym = "Запретить редактирование пользователем")]
        public bool ЗапретитьРедактированиеПользователем {get; set;}
        [Description1C8(Name = "ВключатьСтрануВПредставление", Comment = "", Synonym = "Включать страну в представление")]
        public bool ВключатьСтрануВПредставление {get; set;}
        [Description1C8(Name = "ВидПоляДругое", Comment = "", Synonym = "Вид поля другое")]
        [StringLength(20)]
        public string ВидПоляДругое {get; set;}
        [Description1C8(Name = "РазрешитьВводНесколькихЗначений", Comment = "", Synonym = "Разрешить ввод нескольких значений")]
        public bool РазрешитьВводНесколькихЗначений {get; set;}
        [Description1C8(Name = "РедактированиеТолькоВДиалоге", Comment = "", Synonym = "Редактирование только в диалоге")]
        public bool РедактированиеТолькоВДиалоге {get; set;}
        [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
        // Format 5.0
        public long РеквизитДопУпорядочивания {get; set;}
        [Description1C8(Name = "СкрыватьНеактуальныеАдреса", Comment = "", Synonym = "Скрывать неактуальные адреса")]
        public bool СкрыватьНеактуальныеАдреса {get; set;}
        [Description1C8(Name = "ТелефонCДобавочнымНомером", Comment = "", Synonym = "Телефон c добавочным номером")]
        public bool ТелефонCДобавочнымНомером {get; set;}
        [Description1C8(Name = "Тип", Comment = "", Synonym = "Тип")]
        public Enums.ТипыКонтактнойИнформации Тип {get; set;}
        [Description1C8(Name = "ХранитьИсториюИзменений", Comment = "", Synonym = "Хранить историю изменений")]
        public bool ХранитьИсториюИзменений {get; set;}
        [Description1C8(Name = "МеждународныйФорматАдреса", Comment = "", Synonym = "Международный формат адреса")]
        public bool МеждународныйФорматАдреса {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
