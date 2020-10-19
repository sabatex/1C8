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
    [Table("VydyDohovorovKontrahentov")]
    [Description1C8(Name = "ВидыДоговоровКонтрагентов", Comment = "(Общ)", Synonym = "Виды договоров контрагентов")]
    public class ВидыДоговоровКонтрагентов:EnumItem
    {
        public static readonly ВидыДоговоровКонтрагентов СПоставщиком = new ВидыДоговоровКонтрагентов{Name= "СПоставщиком",Synonym="С поставщиком",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов СПокупателем = new ВидыДоговоровКонтрагентов{Name= "СПокупателем",Synonym="С покупателем",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов СКомитентом = new ВидыДоговоровКонтрагентов{Name= "СКомитентом",Synonym="С комитентом",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов СКомиссионером = new ВидыДоговоровКонтрагентов{Name= "СКомиссионером",Synonym="С комиссионером",Comment="(Общ)"};
        public static readonly ВидыДоговоровКонтрагентов Бартерный = new ВидыДоговоровКонтрагентов{Name= "Бартерный",Synonym="Бартерный",Comment=""};
        public static readonly ВидыДоговоровКонтрагентов Прочее = new ВидыДоговоровКонтрагентов{Name= "Прочее",Synonym="Прочее",Comment="(Общ)"};
    }
}
