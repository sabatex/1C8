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
    [Table("FormatySokhranenyiaOtchetov")]
    [Description1C8(Name = "ФорматыСохраненияОтчетов", Comment = "", Synonym = "Форматы сохранения отчетов")]
    public class ФорматыСохраненияОтчетов:EnumItem
    {
        public static readonly ФорматыСохраненияОтчетов HTML = new ФорматыСохраненияОтчетов{Name= "HTML",Synonym="Веб-страница (.html)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов HTML4 = new ФорматыСохраненияОтчетов{Name= "HTML4",Synonym="Веб-страница версии 4 (.html)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов XLS = new ФорматыСохраненияОтчетов{Name= "XLS",Synonym="Лист Microsoft Excel 97-2003 (.xls)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов XLSX = new ФорматыСохраненияОтчетов{Name= "XLSX",Synonym="Лист Microsoft Excel 2007 (.xlsx)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов PDF = new ФорматыСохраненияОтчетов{Name= "PDF",Synonym="Документ Adobe PDF (.pdf)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов MXL = new ФорматыСохраненияОтчетов{Name= "MXL",Synonym="Табличный документ (.mxl)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов ODS = new ФорматыСохраненияОтчетов{Name= "ODS",Synonym="Электронная таблица Open Document (.ods)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов DOCX = new ФорматыСохраненияОтчетов{Name= "DOCX",Synonym="Документ Word 2007 (.docx)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов TXT = new ФорматыСохраненияОтчетов{Name= "TXT",Synonym="Текстовый документ UTF-8 (.txt)",Comment=""};
        public static readonly ФорматыСохраненияОтчетов ANSITXT = new ФорматыСохраненияОтчетов{Name= "ANSITXT",Synonym="Текстовый документ ANSI (.txt)",Comment=""};
    }
}
