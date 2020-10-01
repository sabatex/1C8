using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыИспользованияАмортизации", Comment = "Виды использования амортизации (аналитика счета 09)", Synonym = "Виды использования амортизации")]
    public enum ВидыИспользованияАмортизации
    {
        [Description1C8(Name = "СтроительствоОбъектов", Comment = "", Synonym = "Строительство объектов")]
        СтроительствоОбъектов,
        [Description1C8(Name = "ПриобретениеОсновныхСредств", Comment = "", Synonym = "Приобретение (изготовление) основных средств")]
        ПриобретениеОсновныхСредств,
        [Description1C8(Name = "УлучшениеОсновныхСредств", Comment = "", Synonym = "Улучшение основных средств")]
        УлучшениеОсновныхСредств,
        [Description1C8(Name = "ПриобретениеНематериальныхАктивов", Comment = "", Synonym = "Приобретение (изготовление) нематериальных активов")]
        ПриобретениеНематериальныхАктивов,
        [Description1C8(Name = "ДругиеКапитальныеРаботы", Comment = "", Synonym = "Другие капитальные работы")]
        ДругиеКапитальныеРаботы,
        [Description1C8(Name = "ПогашениеПолученныхЗаймов", Comment = "", Synonym = "Погашение полученных на капитальные инвестиции займов")]
        ПогашениеПолученныхЗаймов,
        [Description1C8(Name = "Прочее", Comment = "", Synonym = "Прочее")]
        Прочее
    }
}
