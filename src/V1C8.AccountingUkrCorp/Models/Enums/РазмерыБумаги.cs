using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазмерыБумаги", Comment = "", Synonym = "Размеры бумаги")]
    public class РазмерыБумаги:EnumItem
    {
        public static readonly РазмерыБумаги НеЗадано = new РазмерыБумаги{Name= "НеЗадано",Synonim="Не задано",Comment=""};
        public static readonly РазмерыБумаги A3 = new РазмерыБумаги{Name= "A3",Synonim="A3",Comment=""};
        public static readonly РазмерыБумаги A4 = new РазмерыБумаги{Name= "A4",Synonim="A4",Comment=""};
        public static readonly РазмерыБумаги A5 = new РазмерыБумаги{Name= "A5",Synonim="A5",Comment=""};
        public static readonly РазмерыБумаги B4 = new РазмерыБумаги{Name= "B4",Synonim="B4",Comment=""};
        public static readonly РазмерыБумаги B5 = new РазмерыБумаги{Name= "B5",Synonim="B5",Comment=""};
        public static readonly РазмерыБумаги B6 = new РазмерыБумаги{Name= "B6",Synonim="B6",Comment=""};
        public static readonly РазмерыБумаги C4 = new РазмерыБумаги{Name= "C4",Synonim="C4",Comment=""};
        public static readonly РазмерыБумаги C5 = new РазмерыБумаги{Name= "C5",Synonim="C5",Comment=""};
        public static readonly РазмерыБумаги C6 = new РазмерыБумаги{Name= "C6",Synonim="C6",Comment=""};
        public static readonly РазмерыБумаги USExecutive = new РазмерыБумаги{Name= "USExecutive",Synonim="US Executive",Comment=""};
        public static readonly РазмерыБумаги USLegal = new РазмерыБумаги{Name= "USLegal",Synonim="US Legal",Comment=""};
        public static readonly РазмерыБумаги USLetter = new РазмерыБумаги{Name= "USLetter",Synonim="US Letter",Comment=""};
    }
}
