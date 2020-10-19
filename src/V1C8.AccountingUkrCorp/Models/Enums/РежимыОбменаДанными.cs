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
    [Table("RezhymyObmenaDannymy")]
    [Description1C8(Name = "РежимыОбменаДанными", Comment = "", Synonym = "Режимы обмена данными")]
    public class РежимыОбменаДанными:EnumItem
    {
    }
}
