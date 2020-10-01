using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОтношениеКВоинскомуУчету", Comment = "", Synonym = "Отношение к воинскому учету")]
    public enum ОтношениеКВоинскомуУчету
    {
        [Description1C8(Name = "Состоит", Comment = "", Synonym = "Состоит на воинском учете")]
        Состоит,
        [Description1C8(Name = "Встает", Comment = "", Synonym = "Встает на воинский учет")]
        Встает,
        [Description1C8(Name = "НеСостоит", Comment = "", Synonym = "Не состоит на воинском учете (но должен)")]
        НеСостоит,
        [Description1C8(Name = "СнятПоВозрасту", Comment = "", Synonym = "Снят с воинского учета по возрасту")]
        СнятПоВозрасту,
        [Description1C8(Name = "СнятПоСостояниюЗдоровья", Comment = "", Synonym = "Снят с воинского учета по состоянию здоровья")]
        СнятПоСостояниюЗдоровья,
        [Description1C8(Name = "ПризванНаВоинскуюСлужбу", Comment = "", Synonym = "Призван на воинскую службу")]
        ПризванНаВоинскуюСлужбу,
        [Description1C8(Name = "СлужбаПоКонтракту", Comment = "", Synonym = "Служба по контракту")]
        СлужбаПоКонтракту
    }
}
