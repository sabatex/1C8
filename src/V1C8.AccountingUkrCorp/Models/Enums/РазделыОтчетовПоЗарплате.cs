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
    [Table("RazdelyOtchetovPoZarplate")]
    [Description1C8(Name = "РазделыОтчетовПоЗарплате", Comment = "", Synonym = "Разделы отчетов по зарплате")]
    public class РазделыОтчетовПоЗарплате:EnumItem
    {
        public static readonly РазделыОтчетовПоЗарплате Начисления = new РазделыОтчетовПоЗарплате{Name= "Начисления",Synonym="Начисления",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате Удержания = new РазделыОтчетовПоЗарплате{Name= "Удержания",Synonym="Удержания",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате Выплаты = new РазделыОтчетовПоЗарплате{Name= "Выплаты",Synonym="Выплаты",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате ДоходыВНеденежнойФорме = new РазделыОтчетовПоЗарплате{Name= "ДоходыВНеденежнойФорме",Synonym="Доходы в неденежной форме",Comment=""};
        public static readonly РазделыОтчетовПоЗарплате ПогашениеЗадолженности = new РазделыОтчетовПоЗарплате{Name= "ПогашениеЗадолженности",Synonym="Погашение задолженности",Comment=""};
    }
}
