using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипНалоговойДеятельности", Comment = "", Synonym = "Тип налоговой деятельности")]
    public class ТипНалоговойДеятельности:EnumItem
    {
        public static readonly ТипНалоговойДеятельности ОблагаемыйПоОбычнойСтавке = new ТипНалоговойДеятельности{Name= "ОблагаемыйПоОбычнойСтавке",Synonim="Облагаемый по обычной ставке",Comment=""};
        public static readonly ТипНалоговойДеятельности ОсвобожденныйОтНалогообложения = new ТипНалоговойДеятельности{Name= "ОсвобожденныйОтНалогообложения",Synonim="Освобожденный от налогообложения",Comment=""};
        public static readonly ТипНалоговойДеятельности НеОблагаемый = new ТипНалоговойДеятельности{Name= "НеОблагаемый",Synonim="Не облагаемый",Comment=""};
    }
}
