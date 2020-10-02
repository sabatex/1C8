using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыПубликацииДополнительныхОтчетовИОбработок", Comment = "", Synonym = "Варианты публикации дополнительных отчетов и обработок")]
    public class ВариантыПубликацииДополнительныхОтчетовИОбработок:EnumItem
    {
        public static readonly ВариантыПубликацииДополнительныхОтчетовИОбработок Используется = new ВариантыПубликацииДополнительныхОтчетовИОбработок{Name= "Используется",Synonym="Используется",Comment=""};
        public static readonly ВариантыПубликацииДополнительныхОтчетовИОбработок РежимОтладки = new ВариантыПубликацииДополнительныхОтчетовИОбработок{Name= "РежимОтладки",Synonym="Режим отладки",Comment=""};
        public static readonly ВариантыПубликацииДополнительныхОтчетовИОбработок Отключена = new ВариантыПубликацииДополнительныхОтчетовИОбработок{Name= "Отключена",Synonym="Отключена",Comment=""};
    }
}
