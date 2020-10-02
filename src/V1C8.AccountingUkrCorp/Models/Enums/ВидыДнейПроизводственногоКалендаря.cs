using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДнейПроизводственногоКалендаря", Comment = "", Synonym = "Виды дней производственного календаря")]
    public class ВидыДнейПроизводственногоКалендаря:EnumItem
    {
        public static readonly ВидыДнейПроизводственногоКалендаря Рабочий = new ВидыДнейПроизводственногоКалендаря{Name= "Рабочий",Synonim="Рабочий",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Суббота = new ВидыДнейПроизводственногоКалендаря{Name= "Суббота",Synonim="Суббота",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Воскресенье = new ВидыДнейПроизводственногоКалендаря{Name= "Воскресенье",Synonim="Воскресенье",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Предпраздничный = new ВидыДнейПроизводственногоКалендаря{Name= "Предпраздничный",Synonim="Предпраздничный",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Праздник = new ВидыДнейПроизводственногоКалендаря{Name= "Праздник",Synonim="Праздник",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Нерабочий = new ВидыДнейПроизводственногоКалендаря{Name= "Нерабочий",Synonim="Нерабочий",Comment=""};
    }
}
