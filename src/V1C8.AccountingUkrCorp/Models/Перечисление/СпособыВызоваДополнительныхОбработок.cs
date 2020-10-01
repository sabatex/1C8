using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВызоваДополнительныхОбработок", Comment = "", Synonym = "Способы вызова дополнительных обработок")]
    public enum СпособыВызоваДополнительныхОбработок
    {
        [Description1C8(Name = "ВызовКлиентскогоМетода", Comment = "", Synonym = "Вызов клиентского метода")]
        ВызовКлиентскогоМетода,
        [Description1C8(Name = "ВызовСерверногоМетода", Comment = "", Synonym = "Вызов серверного метода")]
        ВызовСерверногоМетода,
        [Description1C8(Name = "ЗаполнениеФормы", Comment = "", Synonym = "Заполнение формы")]
        ЗаполнениеФормы,
        [Description1C8(Name = "ОткрытиеФормы", Comment = "", Synonym = "Открытие формы")]
        ОткрытиеФормы,
        [Description1C8(Name = "СценарийВБезопасномРежиме", Comment = "", Synonym = "Сценарий в безопасном режиме")]
        СценарийВБезопасномРежиме,
        [Description1C8(Name = "ЗагрузкаДанныхИзФайла", Comment = "", Synonym = "Загрузка данных из файла")]
        ЗагрузкаДанныхИзФайла
    }
}
