using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДоговоровКонтрагентов", Comment = "(Общ)", Synonym = "Виды договоров контрагентов")]
    public class ВидыДоговоровКонтрагентов:EnumItem
    {
        public static readonly ВидыДоговоровКонтрагентов СПоставщиком = new ВидыДоговоровКонтрагентов{Name= "СПоставщиком",Synonim="С поставщиком",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов СПокупателем = new ВидыДоговоровКонтрагентов{Name= "СПокупателем",Synonim="С покупателем",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов СКомитентом = new ВидыДоговоровКонтрагентов{Name= "СКомитентом",Synonim="С комитентом",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов СКомиссионером = new ВидыДоговоровКонтрагентов{Name= "СКомиссионером",Synonim="С комиссионером",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов Бартерный = new ВидыДоговоровКонтрагентов{Name= "Бартерный",Synonim="Бартерный",Comment=""};
        public static readonly ВидыДоговоровКонтрагентов Прочее = new ВидыДоговоровКонтрагентов{Name= "Прочее",Synonim="Прочее",Comment="(Общ)"};
    }
}
