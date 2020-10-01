using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОткрытияФайлаНаПросмотр", Comment = "", Synonym = "Способы открытия файла на просмотр")]
    public enum СпособыОткрытияФайлаНаПросмотр
    {
        [Description1C8(Name = "СтандартнымПриложением", Comment = "", Synonym = "Стандартным приложением")]
        СтандартнымПриложением,
        [Description1C8(Name = "ВоВстроенномРедакторе", Comment = "", Synonym = "Во встроенном редакторе")]
        ВоВстроенномРедакторе
    }
}
