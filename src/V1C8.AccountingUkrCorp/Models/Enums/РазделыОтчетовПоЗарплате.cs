using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазделыОтчетовПоЗарплате", Comment = "", Synonym = "Разделы отчетов по зарплате")]
    public class РазделыОтчетовПоЗарплате:EnumItem
    {
        public static readonly РазделыОтчетовПоЗарплате Начисления = new РазделыОтчетовПоЗарплате{Name= "Начисления",Synonim="Начисления",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате Удержания = new РазделыОтчетовПоЗарплате{Name= "Удержания",Synonim="Удержания",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате Выплаты = new РазделыОтчетовПоЗарплате{Name= "Выплаты",Synonim="Выплаты",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате ДоходыВНеденежнойФорме = new РазделыОтчетовПоЗарплате{Name= "ДоходыВНеденежнойФорме",Synonim="Доходы в неденежной форме",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате ПогашениеЗадолженности = new РазделыОтчетовПоЗарплате{Name= "ПогашениеЗадолженности",Synonim="Погашение задолженности",Comment=""};
    }
}
