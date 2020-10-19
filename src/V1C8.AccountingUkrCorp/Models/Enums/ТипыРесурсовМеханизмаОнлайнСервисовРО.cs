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
    [Table("TypyResursovMekhanyzmaOnlainServysovRO")]
    [Description1C8(Name = "ТипыРесурсовМеханизмаОнлайнСервисовРО", Comment = "", Synonym = "Типы ресурсов механизма онлайн-сервисов РО")]
    public class ТипыРесурсовМеханизмаОнлайнСервисовРО:EnumItem
    {
        public static readonly ТипыРесурсовМеханизмаОнлайнСервисовРО СправочникФормИФорматов = new ТипыРесурсовМеханизмаОнлайнСервисовРО{Name= "СправочникФормИФорматов",Synonym="Справочник форм и форматов",Comment=""};
        public static readonly ТипыРесурсовМеханизмаОнлайнСервисовРО СправочникРелизов = new ТипыРесурсовМеханизмаОнлайнСервисовРО{Name= "СправочникРелизов",Synonym="Справочник релизов",Comment=""};
        public static readonly ТипыРесурсовМеханизмаОнлайнСервисовРО ИнформацияОРелизе = new ТипыРесурсовМеханизмаОнлайнСервисовРО{Name= "ИнформацияОРелизе",Synonym="Информация о релизе",Comment=""};
    }
}
