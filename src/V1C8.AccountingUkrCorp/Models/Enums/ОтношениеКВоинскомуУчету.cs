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
    [Table("OtnoshenyeKVoynskomuUchetu")]
    [Description1C8(Name = "ОтношениеКВоинскомуУчету", Comment = "", Synonym = "Отношение к воинскому учету")]
    public class ОтношениеКВоинскомуУчету:EnumItem
    {
        public static readonly ОтношениеКВоинскомуУчету Состоит = new ОтношениеКВоинскомуУчету{Name= "Состоит",Synonym="Состоит на воинском учете",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету Встает = new ОтношениеКВоинскомуУчету{Name= "Встает",Synonym="Встает на воинский учет",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету НеСостоит = new ОтношениеКВоинскомуУчету{Name= "НеСостоит",Synonym="Не состоит на воинском учете (но должен)",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету СнятПоВозрасту = new ОтношениеКВоинскомуУчету{Name= "СнятПоВозрасту",Synonym="Снят с воинского учета по возрасту",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету СнятПоСостояниюЗдоровья = new ОтношениеКВоинскомуУчету{Name= "СнятПоСостояниюЗдоровья",Synonym="Снят с воинского учета по состоянию здоровья",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету ПризванНаВоинскуюСлужбу = new ОтношениеКВоинскомуУчету{Name= "ПризванНаВоинскуюСлужбу",Synonym="Призван на воинскую службу",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету СлужбаПоКонтракту = new ОтношениеКВоинскомуУчету{Name= "СлужбаПоКонтракту",Synonym="Служба по контракту",Comment=""};
    }
}
