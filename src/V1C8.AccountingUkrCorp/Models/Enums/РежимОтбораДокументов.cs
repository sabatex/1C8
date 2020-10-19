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
    [Table("RezhymOtboraDokumentov")]
    [Description1C8(Name = "РежимОтбораДокументов", Comment = "", Synonym = "Режим отбора документов")]
    public class РежимОтбораДокументов:EnumItem
    {
        public static readonly РежимОтбораДокументов ПоРеквизитам = new РежимОтбораДокументов{Name= "ПоРеквизитам",Synonym="По реквизитам",Comment=""};
        public static readonly РежимОтбораДокументов ПоОборотам = new РежимОтбораДокументов{Name= "ПоОборотам",Synonym="По оборотам",Comment=""};
        public static readonly РежимОтбораДокументов ПоОстаткам = new РежимОтбораДокументов{Name= "ПоОстаткам",Synonym="По остаткам",Comment=""};
    }
}
