using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПрофилиОфицеров", Comment = "(Регл)", Synonym = "Профили офицеров")]
    public class ПрофилиОфицеров:EnumItem
    {
        public static readonly ПрофилиОфицеров Командный = new ПрофилиОфицеров{Name= "Командный",Synonim="Командный",Comment=""};
        public static readonly ПрофилиОфицеров Инженерный = new ПрофилиОфицеров{Name= "Инженерный",Synonim="Инженерный",Comment=""};
        public static readonly ПрофилиОфицеров Технический = new ПрофилиОфицеров{Name= "Технический",Synonim="Технический",Comment=""};
        public static readonly ПрофилиОфицеров Юридический = new ПрофилиОфицеров{Name= "Юридический",Synonim="Юридический",Comment=""};
        public static readonly ПрофилиОфицеров Медицинский = new ПрофилиОфицеров{Name= "Медицинский",Synonim="Медицинский",Comment=""};
        public static readonly ПрофилиОфицеров Ветеринарный = new ПрофилиОфицеров{Name= "Ветеринарный",Synonim="Ветеринарный",Comment=""};
        public static readonly ПрофилиОфицеров Оперативный = new ПрофилиОфицеров{Name= "Оперативный",Synonim="Оперативный",Comment=""};
        public static readonly ПрофилиОфицеров Административный = new ПрофилиОфицеров{Name= "Административный",Synonim="Административный",Comment=""};
        public static readonly ПрофилиОфицеров ОперативноТехнический = new ПрофилиОфицеров{Name= "ОперативноТехнический",Synonim="Оперативно-технический",Comment=""};
    }
}
