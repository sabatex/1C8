using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "МоментыОпределенияНалоговойБазы", Comment = "(Регл)", Synonym = "Моменты определения налоговой базы")]
    public enum МоментыОпределенияНалоговойБазы
    {
        [Description1C8(Name = "ПоОплате", Comment = "", Synonym = "По оплате")]
        ПоОплате,
        [Description1C8(Name = "ПоОтгрузке", Comment = "", Synonym = "По отгрузке")]
        ПоОтгрузке,
        [Description1C8(Name = "ПоПервомуСобытию", Comment = "", Synonym = "По первому событию")]
        ПоПервомуСобытию,
        [Description1C8(Name = "НеОпределять", Comment = "", Synonym = "Не определять")]
        НеОпределять
    }
}
