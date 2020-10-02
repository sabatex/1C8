using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыСчетчиковВыгрузки", Comment = "", Synonym = "Типы счетчиков выгрузки")]
    public class ТипыСчетчиковВыгрузки:EnumItem
    {
        public static readonly ТипыСчетчиковВыгрузки СчетчикДокументовВФормате201 = new ТипыСчетчиковВыгрузки{Name= "СчетчикДокументовВФормате201",Synonim="Счетчик документов в формате 2.01",Comment=""};
        public static readonly ТипыСчетчиковВыгрузки СчетчикДокументовВФормате300 = new ТипыСчетчиковВыгрузки{Name= "СчетчикДокументовВФормате300",Synonim="Счетчик документов в формате 3.00",Comment=""};
        public static readonly ТипыСчетчиковВыгрузки СчетчикФайлов = new ТипыСчетчиковВыгрузки{Name= "СчетчикФайлов",Synonim="Счетчик файлов",Comment=""};
        public static readonly ТипыСчетчиковВыгрузки СчетчикФайловАлко = new ТипыСчетчиковВыгрузки{Name= "СчетчикФайловАлко",Synonim="Счетчик файлов для алкогольных деклараций",Comment=""};
    }
}
