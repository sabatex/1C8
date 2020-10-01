using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСФайламиПоДвойномуЩелчку", Comment = "", Synonym = "Действия с файлами по двойному щелчку")]
    public enum ДействияСФайламиПоДвойномуЩелчку
    {
        [Description1C8(Name = "ОткрыватьФайл", Comment = "", Synonym = "Открывать файл")]
        ОткрыватьФайл,
        [Description1C8(Name = "ОткрыватьКарточку", Comment = "", Synonym = "Открывать карточку")]
        ОткрыватьКарточку
    }
}
