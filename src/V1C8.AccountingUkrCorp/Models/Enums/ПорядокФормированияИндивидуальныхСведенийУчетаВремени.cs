using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокФормированияИндивидуальныхСведенийУчетаВремени", Comment = "", Synonym = "Порядок формирования индивидуальных сведений учета времени")]
    public class ПорядокФормированияИндивидуальныхСведенийУчетаВремени:EnumItem
    {
        public static readonly ПорядокФормированияИндивидуальныхСведенийУчетаВремени НеФормировать = new ПорядокФормированияИндивидуальныхСведенийУчетаВремени{Name= "НеФормировать",Synonym="Не формировать",Comment=""};
        public static readonly ПорядокФормированияИндивидуальныхСведенийУчетаВремени ФормироватьПоЗарегистрированнымВидамВремени = new ПорядокФормированияИндивидуальныхСведенийУчетаВремени{Name= "ФормироватьПоЗарегистрированнымВидамВремени",Synonym="Формировать по зарегистрированным видам времени",Comment=""};
        public static readonly ПорядокФормированияИндивидуальныхСведенийУчетаВремени ФормироватьПолностью = new ПорядокФормированияИндивидуальныхСведенийУчетаВремени{Name= "ФормироватьПолностью",Synonym="Формировать полностью",Comment=""};
    }
}
