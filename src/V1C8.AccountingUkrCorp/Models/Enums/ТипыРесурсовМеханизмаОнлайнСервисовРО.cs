using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыРесурсовМеханизмаОнлайнСервисовРО", Comment = "", Synonym = "Типы ресурсов механизма онлайн-сервисов РО")]
    public class ТипыРесурсовМеханизмаОнлайнСервисовРО:EnumItem
    {
        public static readonly ТипыРесурсовМеханизмаОнлайнСервисовРО СправочникФормИФорматов = new ТипыРесурсовМеханизмаОнлайнСервисовРО{Name= "СправочникФормИФорматов",Synonim="Справочник форм и форматов",Comment=""};
        public static readonly ТипыРесурсовМеханизмаОнлайнСервисовРО СправочникРелизов = new ТипыРесурсовМеханизмаОнлайнСервисовРО{Name= "СправочникРелизов",Synonim="Справочник релизов",Comment=""};
        public static readonly ТипыРесурсовМеханизмаОнлайнСервисовРО ИнформацияОРелизе = new ТипыРесурсовМеханизмаОнлайнСервисовРО{Name= "ИнформацияОРелизе",Synonim="Информация о релизе",Comment=""};
    }
}
