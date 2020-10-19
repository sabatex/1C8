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
    [Table("MomentyOpredelenyiaNalohovoiBazy")]
    [Description1C8(Name = "МоментыОпределенияНалоговойБазы", Comment = "(Регл)", Synonym = "Моменты определения налоговой базы")]
    public class МоментыОпределенияНалоговойБазы:EnumItem
    {
        public static readonly МоментыОпределенияНалоговойБазы ПоОплате = new МоментыОпределенияНалоговойБазы{Name= "ПоОплате",Synonym="По оплате",Comment=""};
        public static readonly МоментыОпределенияНалоговойБазы ПоОтгрузке = new МоментыОпределенияНалоговойБазы{Name= "ПоОтгрузке",Synonym="По отгрузке",Comment=""};
        public static readonly МоментыОпределенияНалоговойБазы ПоПервомуСобытию = new МоментыОпределенияНалоговойБазы{Name= "ПоПервомуСобытию",Synonym="По первому событию",Comment=""};
        public static readonly МоментыОпределенияНалоговойБазы НеОпределять = new МоментыОпределенияНалоговойБазы{Name= "НеОпределять",Synonym="Не определять",Comment=""};
    }
}
