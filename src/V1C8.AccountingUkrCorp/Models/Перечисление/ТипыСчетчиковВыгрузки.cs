using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыСчетчиковВыгрузки", Comment = "", Synonym = "Типы счетчиков выгрузки")]
    public enum ТипыСчетчиковВыгрузки
    {
        [Description1C8(Name = "СчетчикДокументовВФормате201", Comment = "", Synonym = "Счетчик документов в формате 2.01")]
        СчетчикДокументовВФормате201,
        [Description1C8(Name = "СчетчикДокументовВФормате300", Comment = "", Synonym = "Счетчик документов в формате 3.00")]
        СчетчикДокументовВФормате300,
        [Description1C8(Name = "СчетчикФайлов", Comment = "", Synonym = "Счетчик файлов")]
        СчетчикФайлов,
        [Description1C8(Name = "СчетчикФайловАлко", Comment = "", Synonym = "Счетчик файлов для алкогольных деклараций")]
        СчетчикФайловАлко
    }
}
