using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСУдержаниями", Comment = "", Synonym = "Действия с удержаниями")]
    public class ДействияСУдержаниями:EnumItem
    {
        public static readonly ДействияСУдержаниями Начать = new ДействияСУдержаниями{Name= "Начать",Synonim="Начать",Comment=""};
        public static readonly ДействияСУдержаниями Изменить = new ДействияСУдержаниями{Name= "Изменить",Synonim="Изменить",Comment=""};
        public static readonly ДействияСУдержаниями Прекратить = new ДействияСУдержаниями{Name= "Прекратить",Synonim="Прекратить",Comment=""};
    }
}
