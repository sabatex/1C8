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
    [Table("DopolnytelnaiaKolonkaPechatnykhFormDokumentov")]
    [Description1C8(Name = "ДополнительнаяКолонкаПечатныхФормДокументов", Comment = "(Общ)", Synonym = "Дополнительная колонка печатных форм документов")]
    public class ДополнительнаяКолонкаПечатныхФормДокументов:EnumItem
    {
        public static readonly ДополнительнаяКолонкаПечатныхФормДокументов НеВыводить = new ДополнительнаяКолонкаПечатныхФормДокументов{Name= "НеВыводить",Synonym="Не выводить",Comment="(Общ)"};
        public static readonly ДополнительнаяКолонкаПечатныхФормДокументов Артикул = new ДополнительнаяКолонкаПечатныхФормДокументов{Name= "Артикул",Synonym="Артикул",Comment="(Общ)"};
        public static readonly ДополнительнаяКолонкаПечатныхФормДокументов Код = new ДополнительнаяКолонкаПечатныхФормДокументов{Name= "Код",Synonym="Код",Comment="(Общ)"};
    }
}
