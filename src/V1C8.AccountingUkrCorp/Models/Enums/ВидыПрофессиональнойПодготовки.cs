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
    [Table("VydyProfessyonalnoiPodhotovky")]
    [Description1C8(Name = "ВидыПрофессиональнойПодготовки", Comment = "", Synonym = "Виды профессиональной подготовки")]
    public class ВидыПрофессиональнойПодготовки:EnumItem
    {
        public static readonly ВидыПрофессиональнойПодготовки Переподготовка = new ВидыПрофессиональнойПодготовки{Name= "Переподготовка",Synonym="Переподготовка",Comment=""};
        public static readonly ВидыПрофессиональнойПодготовки ПовышениеКвалификации = new ВидыПрофессиональнойПодготовки{Name= "ПовышениеКвалификации",Synonym="Повышение квалификации",Comment=""};
    }
}
