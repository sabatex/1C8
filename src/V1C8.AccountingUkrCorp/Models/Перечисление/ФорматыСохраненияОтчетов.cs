using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФорматыСохраненияОтчетов", Comment = "", Synonym = "Форматы сохранения отчетов")]
    public enum ФорматыСохраненияОтчетов
    {
        [Description1C8(Name = "HTML", Comment = "", Synonym = "Веб-страница (.html)")]
        HTML,
        [Description1C8(Name = "HTML4", Comment = "", Synonym = "Веб-страница версии 4 (.html)")]
        HTML4,
        [Description1C8(Name = "XLS", Comment = "", Synonym = "Лист Microsoft Excel 97-2003 (.xls)")]
        XLS,
        [Description1C8(Name = "XLSX", Comment = "", Synonym = "Лист Microsoft Excel 2007 (.xlsx)")]
        XLSX,
        [Description1C8(Name = "PDF", Comment = "", Synonym = "Документ Adobe PDF (.pdf)")]
        PDF,
        [Description1C8(Name = "MXL", Comment = "", Synonym = "Табличный документ (.mxl)")]
        MXL,
        [Description1C8(Name = "ODS", Comment = "", Synonym = "Электронная таблица Open Document (.ods)")]
        ODS,
        [Description1C8(Name = "DOCX", Comment = "", Synonym = "Документ Word 2007 (.docx)")]
        DOCX,
        [Description1C8(Name = "TXT", Comment = "", Synonym = "Текстовый документ UTF-8 (.txt)")]
        TXT,
        [Description1C8(Name = "ANSITXT", Comment = "", Synonym = "Текстовый документ ANSI (.txt)")]
        ANSITXT
    }
}
