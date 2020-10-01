using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыХраненияФайлов", Comment = "", Synonym = "Типы хранения файлов")]
    public enum ТипыХраненияФайлов
    {
        [Description1C8(Name = "ВИнформационнойБазе", Comment = "", Synonym = "В информационной базе")]
        ВИнформационнойБазе,
        [Description1C8(Name = "ВТомахНаДиске", Comment = "", Synonym = "В томах на диске")]
        ВТомахНаДиске
    }
}
