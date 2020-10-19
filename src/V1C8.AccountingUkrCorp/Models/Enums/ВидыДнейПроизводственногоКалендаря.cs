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
    [Table("VydyDneiProyzvodstvennohoKalendaria")]
    [Description1C8(Name = "ВидыДнейПроизводственногоКалендаря", Comment = "", Synonym = "Виды дней производственного календаря")]
    public class ВидыДнейПроизводственногоКалендаря:EnumItem
    {
        public static readonly ВидыДнейПроизводственногоКалендаря Рабочий = new ВидыДнейПроизводственногоКалендаря{Name= "Рабочий",Synonym="Рабочий",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Суббота = new ВидыДнейПроизводственногоКалендаря{Name= "Суббота",Synonym="Суббота",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Воскресенье = new ВидыДнейПроизводственногоКалендаря{Name= "Воскресенье",Synonym="Воскресенье",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Предпраздничный = new ВидыДнейПроизводственногоКалендаря{Name= "Предпраздничный",Synonym="Предпраздничный",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Праздник = new ВидыДнейПроизводственногоКалендаря{Name= "Праздник",Synonym="Праздник",Comment=""};
        public static readonly ВидыДнейПроизводственногоКалендаря Нерабочий = new ВидыДнейПроизводственногоКалендаря{Name= "Нерабочий",Synonym="Нерабочий",Comment=""};
    }
}
