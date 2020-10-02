using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыХраненияФайлов", Comment = "", Synonym = "Типы хранения файлов")]
    public class ТипыХраненияФайлов:EnumItem
    {
        public static readonly ТипыХраненияФайлов ВИнформационнойБазе = new ТипыХраненияФайлов{Name= "ВИнформационнойБазе",Synonim="В информационной базе",Comment=""};
        public static readonly ТипыХраненияФайлов ВТомахНаДиске = new ТипыХраненияФайлов{Name= "ВТомахНаДиске",Synonim="В томах на диске",Comment=""};
    }
}
