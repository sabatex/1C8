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
    [Table("ProfylyOfytserov")]
    [Description1C8(Name = "ПрофилиОфицеров", Comment = "(Регл)", Synonym = "Профили офицеров")]
    public class ПрофилиОфицеров:EnumItem
    {
        public static readonly ПрофилиОфицеров Командный = new ПрофилиОфицеров{Name= "Командный",Synonym="Командный",Comment=""};
        public static readonly ПрофилиОфицеров Инженерный = new ПрофилиОфицеров{Name= "Инженерный",Synonym="Инженерный",Comment=""};
        public static readonly ПрофилиОфицеров Технический = new ПрофилиОфицеров{Name= "Технический",Synonym="Технический",Comment=""};
        public static readonly ПрофилиОфицеров Юридический = new ПрофилиОфицеров{Name= "Юридический",Synonym="Юридический",Comment=""};
        public static readonly ПрофилиОфицеров Медицинский = new ПрофилиОфицеров{Name= "Медицинский",Synonym="Медицинский",Comment=""};
        public static readonly ПрофилиОфицеров Ветеринарный = new ПрофилиОфицеров{Name= "Ветеринарный",Synonym="Ветеринарный",Comment=""};
        public static readonly ПрофилиОфицеров Оперативный = new ПрофилиОфицеров{Name= "Оперативный",Synonym="Оперативный",Comment=""};
        public static readonly ПрофилиОфицеров Административный = new ПрофилиОфицеров{Name= "Административный",Synonym="Административный",Comment=""};
        public static readonly ПрофилиОфицеров ОперативноТехнический = new ПрофилиОфицеров{Name= "ОперативноТехнический",Synonym="Оперативно-технический",Comment=""};
    }
}
