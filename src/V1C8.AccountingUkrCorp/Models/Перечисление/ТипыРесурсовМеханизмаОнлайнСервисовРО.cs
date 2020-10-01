using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыРесурсовМеханизмаОнлайнСервисовРО", Comment = "", Synonym = "Типы ресурсов механизма онлайн-сервисов РО")]
    public enum ТипыРесурсовМеханизмаОнлайнСервисовРО
    {
        [Description1C8(Name = "СправочникФормИФорматов", Comment = "", Synonym = "Справочник форм и форматов")]
        СправочникФормИФорматов,
        [Description1C8(Name = "СправочникРелизов", Comment = "", Synonym = "Справочник релизов")]
        СправочникРелизов,
        [Description1C8(Name = "ИнформацияОРелизе", Comment = "", Synonym = "Информация о релизе")]
        ИнформацияОРелизе
    }
}
