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
    [Table("RazmeryBumahy")]
    [Description1C8(Name = "РазмерыБумаги", Comment = "", Synonym = "Размеры бумаги")]
    public class РазмерыБумаги:EnumItem
    {
        public static readonly РазмерыБумаги НеЗадано = new РазмерыБумаги{Name= "НеЗадано",Synonym="Не задано",Comment=""};
        public static readonly РазмерыБумаги A3 = new РазмерыБумаги{Name= "A3",Synonym="A3",Comment=""};
        public static readonly РазмерыБумаги A4 = new РазмерыБумаги{Name= "A4",Synonym="A4",Comment=""};
        public static readonly РазмерыБумаги A5 = new РазмерыБумаги{Name= "A5",Synonym="A5",Comment=""};
        public static readonly РазмерыБумаги B4 = new РазмерыБумаги{Name= "B4",Synonym="B4",Comment=""};
        public static readonly РазмерыБумаги B5 = new РазмерыБумаги{Name= "B5",Synonym="B5",Comment=""};
        public static readonly РазмерыБумаги B6 = new РазмерыБумаги{Name= "B6",Synonym="B6",Comment=""};
        public static readonly РазмерыБумаги C4 = new РазмерыБумаги{Name= "C4",Synonym="C4",Comment=""};
        public static readonly РазмерыБумаги C5 = new РазмерыБумаги{Name= "C5",Synonym="C5",Comment=""};
        public static readonly РазмерыБумаги C6 = new РазмерыБумаги{Name= "C6",Synonym="C6",Comment=""};
        public static readonly РазмерыБумаги USExecutive = new РазмерыБумаги{Name= "USExecutive",Synonym="US Executive",Comment=""};
        public static readonly РазмерыБумаги USLegal = new РазмерыБумаги{Name= "USLegal",Synonym="US Legal",Comment=""};
        public static readonly РазмерыБумаги USLetter = new РазмерыБумаги{Name= "USLetter",Synonym="US Letter",Comment=""};
    }
}
