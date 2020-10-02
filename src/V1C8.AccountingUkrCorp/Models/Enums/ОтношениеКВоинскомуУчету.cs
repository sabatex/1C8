using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОтношениеКВоинскомуУчету", Comment = "", Synonym = "Отношение к воинскому учету")]
    public class ОтношениеКВоинскомуУчету:EnumItem
    {
        public static readonly ОтношениеКВоинскомуУчету Состоит = new ОтношениеКВоинскомуУчету{Name= "Состоит",Synonim="Состоит на воинском учете",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету Встает = new ОтношениеКВоинскомуУчету{Name= "Встает",Synonim="Встает на воинский учет",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету НеСостоит = new ОтношениеКВоинскомуУчету{Name= "НеСостоит",Synonim="Не состоит на воинском учете (но должен)",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету СнятПоВозрасту = new ОтношениеКВоинскомуУчету{Name= "СнятПоВозрасту",Synonim="Снят с воинского учета по возрасту",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету СнятПоСостояниюЗдоровья = new ОтношениеКВоинскомуУчету{Name= "СнятПоСостояниюЗдоровья",Synonim="Снят с воинского учета по состоянию здоровья",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету ПризванНаВоинскуюСлужбу = new ОтношениеКВоинскомуУчету{Name= "ПризванНаВоинскуюСлужбу",Synonim="Призван на воинскую службу",Comment=""};
        public static readonly ОтношениеКВоинскомуУчету СлужбаПоКонтракту = new ОтношениеКВоинскомуУчету{Name= "СлужбаПоКонтракту",Synonim="Служба по контракту",Comment=""};
    }
}
