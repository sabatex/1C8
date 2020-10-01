using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСПозициямиШтатногоРасписания", Comment = "", Synonym = "Действия с позициями штатного расписания")]
    public enum ДействияСПозициямиШтатногоРасписания
    {
        [Description1C8(Name = "СоздатьНовуюПозицию", Comment = "", Synonym = "Создать новую позицию")]
        СоздатьНовуюПозицию,
        [Description1C8(Name = "ЗакрытьПозицию", Comment = "", Synonym = "Закрыть позицию")]
        ЗакрытьПозицию
    }
}
