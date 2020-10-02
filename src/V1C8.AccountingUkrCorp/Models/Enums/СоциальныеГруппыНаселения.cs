using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СоциальныеГруппыНаселения", Comment = "", Synonym = "Социальные группы населения")]
    public class СоциальныеГруппыНаселения:EnumItem
    {
        public static readonly СоциальныеГруппыНаселения ДетиДо6 = new СоциальныеГруппыНаселения{Name= "ДетиДо6",Synonym="Дети до 6 лет",Comment=""};
        public static readonly СоциальныеГруппыНаселения ДетиДо18 = new СоциальныеГруппыНаселения{Name= "ДетиДо18",Synonym="Дети от 6 до18 лет",Comment=""};
        public static readonly СоциальныеГруппыНаселения Трудоспособные = new СоциальныеГруппыНаселения{Name= "Трудоспособные",Synonym="Трудоспособные",Comment=""};
        public static readonly СоциальныеГруппыНаселения НеТрудоспособные = new СоциальныеГруппыНаселения{Name= "НеТрудоспособные",Synonym="Нетрудоспособные",Comment=""};
    }
}
