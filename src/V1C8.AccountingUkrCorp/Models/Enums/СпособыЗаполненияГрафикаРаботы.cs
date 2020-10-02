using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыЗаполненияГрафикаРаботы", Comment = "", Synonym = "Способы заполнения графика работы")]
    public class СпособыЗаполненияГрафикаРаботы:EnumItem
    {
        public static readonly СпособыЗаполненияГрафикаРаботы ПоНеделям = new СпособыЗаполненияГрафикаРаботы{Name= "ПоНеделям",Synonim="По неделям",Comment=""};
        public static readonly СпособыЗаполненияГрафикаРаботы ПоЦикламПроизвольнойДлины = new СпособыЗаполненияГрафикаРаботы{Name= "ПоЦикламПроизвольнойДлины",Synonim="По циклам произвольной длины",Comment=""};
    }
}
