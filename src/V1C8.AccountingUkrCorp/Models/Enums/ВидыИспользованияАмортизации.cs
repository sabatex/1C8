using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыИспользованияАмортизации", Comment = "Виды использования амортизации (аналитика счета 09)", Synonym = "Виды использования амортизации")]
    public class ВидыИспользованияАмортизации:EnumItem
    {
        public static readonly ВидыИспользованияАмортизации СтроительствоОбъектов = new ВидыИспользованияАмортизации{Name= "СтроительствоОбъектов",Synonim="Строительство объектов",Comment=""};
        public static readonly ВидыИспользованияАмортизации ПриобретениеОсновныхСредств = new ВидыИспользованияАмортизации{Name= "ПриобретениеОсновныхСредств",Synonim="Приобретение (изготовление) основных средств",Comment=""};
        public static readonly ВидыИспользованияАмортизации УлучшениеОсновныхСредств = new ВидыИспользованияАмортизации{Name= "УлучшениеОсновныхСредств",Synonim="Улучшение основных средств",Comment=""};
        public static readonly ВидыИспользованияАмортизации ПриобретениеНематериальныхАктивов = new ВидыИспользованияАмортизации{Name= "ПриобретениеНематериальныхАктивов",Synonim="Приобретение (изготовление) нематериальных активов",Comment=""};
        public static readonly ВидыИспользованияАмортизации ДругиеКапитальныеРаботы = new ВидыИспользованияАмортизации{Name= "ДругиеКапитальныеРаботы",Synonim="Другие капитальные работы",Comment=""};
        public static readonly ВидыИспользованияАмортизации ПогашениеПолученныхЗаймов = new ВидыИспользованияАмортизации{Name= "ПогашениеПолученныхЗаймов",Synonim="Погашение полученных на капитальные инвестиции займов",Comment=""};
        public static readonly ВидыИспользованияАмортизации Прочее = new ВидыИспользованияАмортизации{Name= "Прочее",Synonim="Прочее",Comment=""};
    }
}
