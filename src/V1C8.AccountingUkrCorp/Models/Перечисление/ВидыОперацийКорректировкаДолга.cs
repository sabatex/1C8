using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийКорректировкаДолга", Comment = "(Общ)", Synonym = "Виды операций документа 'Корректировка долга по возвратной таре'")]
    public enum ВидыОперацийКорректировкаДолга
    {
        [Description1C8(Name = "ПереносЗадолженности", Comment = "(Общ)", Synonym = "Перенос задолженности")]
        ПереносЗадолженности,
        [Description1C8(Name = "СписаниеЗадолженности", Comment = "", Synonym = "Списание безнадежной задолженности")]
        СписаниеЗадолженности,
        [Description1C8(Name = "ИзменениеЗадолженности", Comment = "", Synonym = "Изменение (формирование) задолженности")]
        ИзменениеЗадолженности,
        [Description1C8(Name = "ПроведениеВзаимозачета", Comment = "(Общ)", Synonym = "Проведение взаимозачета")]
        ПроведениеВзаимозачета,
        [Description1C8(Name = "ВводНачальныхОстатков", Comment = "", Synonym = "Ввод начальных остатков")]
        ВводНачальныхОстатков
    }
}
