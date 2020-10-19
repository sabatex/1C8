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
    [Table("VydyStoymosty")]
    [Description1C8(Name = "ВидыСтоимости", Comment = "", Synonym = "Виды стоимости выпуска")]
    public class ВидыСтоимости:EnumItem
    {
        public static readonly ВидыСтоимости Фактическая = new ВидыСтоимости{Name= "Фактическая",Synonym="Выпуск по фактической стоимости",Comment="Выпуск по фактической стоимости"};
        public static readonly ВидыСтоимости Плановая = new ВидыСтоимости{Name= "Плановая",Synonym="Выпуск по плановой стоимости",Comment="Выпуск по плановой стоимости"};
        public static readonly ВидыСтоимости Отклонение = new ВидыСтоимости{Name= "Отклонение",Synonym="Отклонение",Comment="Отклонение фактической стоимости выпуска от плановой"};
    }
}
