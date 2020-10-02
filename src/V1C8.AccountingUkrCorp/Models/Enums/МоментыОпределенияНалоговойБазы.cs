using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "МоментыОпределенияНалоговойБазы", Comment = "(Регл)", Synonym = "Моменты определения налоговой базы")]
    public class МоментыОпределенияНалоговойБазы:EnumItem
    {
        public static readonly МоментыОпределенияНалоговойБазы ПоОплате = new МоментыОпределенияНалоговойБазы{Name= "ПоОплате",Synonim="По оплате",Comment=""};
        public static readonly МоментыОпределенияНалоговойБазы ПоОтгрузке = new МоментыОпределенияНалоговойБазы{Name= "ПоОтгрузке",Synonim="По отгрузке",Comment=""};
        public static readonly МоментыОпределенияНалоговойБазы ПоПервомуСобытию = new МоментыОпределенияНалоговойБазы{Name= "ПоПервомуСобытию",Synonim="По первому событию",Comment=""};
        public static readonly МоментыОпределенияНалоговойБазы НеОпределять = new МоментыОпределенияНалоговойБазы{Name= "НеОпределять",Synonim="Не определять",Comment=""};
    }
}
