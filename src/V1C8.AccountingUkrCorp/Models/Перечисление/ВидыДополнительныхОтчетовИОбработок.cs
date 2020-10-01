using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДополнительныхОтчетовИОбработок", Comment = "", Synonym = "Виды дополнительных отчетов и обработок")]
    public enum ВидыДополнительныхОтчетовИОбработок
    {
        [Description1C8(Name = "ДополнительнаяОбработка", Comment = "", Synonym = "Дополнительная обработка")]
        ДополнительнаяОбработка,
        [Description1C8(Name = "ДополнительныйОтчет", Comment = "", Synonym = "Дополнительный отчет")]
        ДополнительныйОтчет,
        [Description1C8(Name = "ЗаполнениеОбъекта", Comment = "", Synonym = "Заполнение объекта")]
        ЗаполнениеОбъекта,
        [Description1C8(Name = "Отчет", Comment = "", Synonym = "Отчет")]
        Отчет,
        [Description1C8(Name = "ПечатнаяФорма", Comment = "", Synonym = "Печатная форма")]
        ПечатнаяФорма,
        [Description1C8(Name = "СозданиеСвязанныхОбъектов", Comment = "", Synonym = "Создание связанных объектов")]
        СозданиеСвязанныхОбъектов,
        [Description1C8(Name = "ШаблонСообщения", Comment = "", Synonym = "Шаблон сообщения")]
        ШаблонСообщения
    }
}
