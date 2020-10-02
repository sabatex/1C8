using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПоворотаИзображения", Comment = "", Synonym = "Способы поворота изображения")]
    public class СпособыПоворотаИзображения:EnumItem
    {
        public static readonly СпособыПоворотаИзображения НетПоворота = new СпособыПоворотаИзображения{Name= "НетПоворота",Synonim="Нет поворота",Comment=""};
        public static readonly СпособыПоворотаИзображения ВправоНа90 = new СпособыПоворотаИзображения{Name= "ВправоНа90",Synonim="Вправо на 90",Comment=""};
        public static readonly СпособыПоворотаИзображения ВправоНа180 = new СпособыПоворотаИзображения{Name= "ВправоНа180",Synonim="Вправо на 180",Comment=""};
        public static readonly СпособыПоворотаИзображения ВлевоНа90 = new СпособыПоворотаИзображения{Name= "ВлевоНа90",Synonim="Влево на 90",Comment=""};
    }
}
