using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("TypyFailovDliaVstroennohoRedaktora")]
    [Description1C8(Name = "ТипыФайловДляВстроенногоРедактора", Comment = "", Synonym = "Типы файлов для встроенного редактора")]
    public class ТипыФайловДляВстроенногоРедактора:EnumItem
    {
        public static readonly ТипыФайловДляВстроенногоРедактора ГеографическиеСхемы = new ТипыФайловДляВстроенногоРедактора{Name= "ГеографическиеСхемы",Synonym="Географические схемы",Comment=""};
        public static readonly ТипыФайловДляВстроенногоРедактора ГрафическиеСхемы = new ТипыФайловДляВстроенногоРедактора{Name= "ГрафическиеСхемы",Synonym="Графические схемы",Comment=""};
        public static readonly ТипыФайловДляВстроенногоРедактора ТабличныеФайлы = new ТипыФайловДляВстроенногоРедактора{Name= "ТабличныеФайлы",Synonym="Табличные файлы",Comment=""};
        public static readonly ТипыФайловДляВстроенногоРедактора ТекстовыеФайлы = new ТипыФайловДляВстроенногоРедактора{Name= "ТекстовыеФайлы",Synonym="Текстовые файлы",Comment=""};
    }
}
