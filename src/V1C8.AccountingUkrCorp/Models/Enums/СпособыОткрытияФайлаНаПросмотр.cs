using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОткрытияФайлаНаПросмотр", Comment = "", Synonym = "Способы открытия файла на просмотр")]
    public class СпособыОткрытияФайлаНаПросмотр:EnumItem
    {
        public static readonly СпособыОткрытияФайлаНаПросмотр СтандартнымПриложением = new СпособыОткрытияФайлаНаПросмотр{Name= "СтандартнымПриложением",Synonim="Стандартным приложением",Comment=""};
        public static readonly СпособыОткрытияФайлаНаПросмотр ВоВстроенномРедакторе = new СпособыОткрытияФайлаНаПросмотр{Name= "ВоВстроенномРедакторе",Synonim="Во встроенном редакторе",Comment=""};
    }
}
