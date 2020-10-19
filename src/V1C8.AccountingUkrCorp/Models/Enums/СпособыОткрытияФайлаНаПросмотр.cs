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
    [Table("SposobyOtkrytyiaFailaNaProsmotr")]
    [Description1C8(Name = "СпособыОткрытияФайлаНаПросмотр", Comment = "", Synonym = "Способы открытия файла на просмотр")]
    public class СпособыОткрытияФайлаНаПросмотр:EnumItem
    {
        public static readonly СпособыОткрытияФайлаНаПросмотр СтандартнымПриложением = new СпособыОткрытияФайлаНаПросмотр{Name= "СтандартнымПриложением",Synonym="Стандартным приложением",Comment=""};
        public static readonly СпособыОткрытияФайлаНаПросмотр ВоВстроенномРедакторе = new СпособыОткрытияФайлаНаПросмотр{Name= "ВоВстроенномРедакторе",Synonym="Во встроенном редакторе",Comment=""};
    }
}
