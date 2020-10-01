using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыФайловДляВстроенногоРедактора", Comment = "", Synonym = "Типы файлов для встроенного редактора")]
    public enum ТипыФайловДляВстроенногоРедактора
    {
        [Description1C8(Name = "ГеографическиеСхемы", Comment = "", Synonym = "Географические схемы")]
        ГеографическиеСхемы,
        [Description1C8(Name = "ГрафическиеСхемы", Comment = "", Synonym = "Графические схемы")]
        ГрафическиеСхемы,
        [Description1C8(Name = "ТабличныеФайлы", Comment = "", Synonym = "Табличные файлы")]
        ТабличныеФайлы,
        [Description1C8(Name = "ТекстовыеФайлы", Comment = "", Synonym = "Текстовые файлы")]
        ТекстовыеФайлы
    }
}
