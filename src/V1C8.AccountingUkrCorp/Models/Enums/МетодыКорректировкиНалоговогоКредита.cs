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
    [Table("MetodyKorrektyrovkyNalohovohoKredyta")]
    [Description1C8(Name = "МетодыКорректировкиНалоговогоКредита", Comment = "(Регл)", Synonym = "Методы корректировки налогового кредита")]
    public class МетодыКорректировкиНалоговогоКредита:EnumItem
    {
        public static readonly МетодыКорректировкиНалоговогоКредита НаНалоговыйКредит = new МетодыКорректировкиНалоговогоКредита{Name= "НаНалоговыйКредит",Synonym="Начислить кредит",Comment=""};
        public static readonly МетодыКорректировкиНалоговогоКредита НаНалоговыеОбязательства = new МетодыКорректировкиНалоговогоКредита{Name= "НаНалоговыеОбязательства",Synonym="Начислить обязательства",Comment=""};
        public static readonly МетодыКорректировкиНалоговогоКредита НеКорректировать = new МетодыКорректировкиНалоговогоКредита{Name= "НеКорректировать",Synonym="Не корректировать",Comment=""};
    }
}
