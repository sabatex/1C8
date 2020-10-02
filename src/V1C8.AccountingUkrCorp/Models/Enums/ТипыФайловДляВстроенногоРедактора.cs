using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыФайловДляВстроенногоРедактора", Comment = "", Synonym = "Типы файлов для встроенного редактора")]
    public class ТипыФайловДляВстроенногоРедактора:EnumItem
    {
        public static readonly ТипыФайловДляВстроенногоРедактора ГеографическиеСхемы = new ТипыФайловДляВстроенногоРедактора{Name= "ГеографическиеСхемы",Synonim="Географические схемы",Comment=""};
        public static readonly ТипыФайловДляВстроенногоРедактора ГрафическиеСхемы = new ТипыФайловДляВстроенногоРедактора{Name= "ГрафическиеСхемы",Synonim="Графические схемы",Comment=""};
        public static readonly ТипыФайловДляВстроенногоРедактора ТабличныеФайлы = new ТипыФайловДляВстроенногоРедактора{Name= "ТабличныеФайлы",Synonim="Табличные файлы",Comment=""};
        public static readonly ТипыФайловДляВстроенногоРедактора ТекстовыеФайлы = new ТипыФайловДляВстроенногоРедактора{Name= "ТекстовыеФайлы",Synonim="Текстовые файлы",Comment=""};
    }
}
