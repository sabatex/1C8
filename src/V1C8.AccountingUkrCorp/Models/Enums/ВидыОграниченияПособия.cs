using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОграниченияПособия", Comment = "", Synonym = "Виды ограничения пособия")]
    public class ВидыОграниченияПособия:EnumItem
    {
        public static readonly ВидыОграниченияПособия ОбщееОграничение = new ВидыОграниченияПособия{Name= "ОбщееОграничение",Synonym="Предельной величиной базы для начисления страховых взносов",Comment=""};
        public static readonly ВидыОграниченияПособия ОграничениеВРазмереММОТ = new ВидыОграниченияПособия{Name= "ОграничениеВРазмереММОТ",Synonym="В размере ММОТ",Comment=""};
        public static readonly ВидыОграниченияПособия БезОграничений = new ВидыОграниченияПособия{Name= "БезОграничений",Synonym="Отсутствует",Comment=""};
        public static readonly ВидыОграниченияПособия МаксимальныйРазмерЕжемесячнойСтраховойВыплаты = new ВидыОграниченияПособия{Name= "МаксимальныйРазмерЕжемесячнойСтраховойВыплаты",Synonym="ѳ(не украинский) Максимальным размером ежемесячной страховой выплаты",Comment=""};
        public static readonly ВидыОграниченияПособия ОграничениеВРазмереДвухММОТ = new ВидыОграниченияПособия{Name= "ОграничениеВРазмереДвухММОТ",Synonym="Ограничение в размере двух ММОТ",Comment=""};
    }
}
