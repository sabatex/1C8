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
    [Table("OtvetstvennyeLytsaOrhanyzatsyi")]
    [Description1C8(Name = "ОтветственныеЛицаОрганизаций", Comment = "(Регл)", Synonym = "Ответственные лица организаций")]
    public class ОтветственныеЛицаОрганизаций:EnumItem
    {
        public static readonly ОтветственныеЛицаОрганизаций Руководитель = new ОтветственныеЛицаОрганизаций{Name= "Руководитель",Synonym="Руководитель",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций ГлавныйБухгалтер = new ОтветственныеЛицаОрганизаций{Name= "ГлавныйБухгалтер",Synonym="Главный бухгалтер",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций РуководительКадровойСлужбы = new ОтветственныеЛицаОрганизаций{Name= "РуководительКадровойСлужбы",Synonym="Руководитель кадровой службы",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций Кассир = new ОтветственныеЛицаОрганизаций{Name= "Кассир",Synonym="Кассир",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций ОтветственныйЗаБухгалтерскиеРегистры = new ОтветственныеЛицаОрганизаций{Name= "ОтветственныйЗаБухгалтерскиеРегистры",Synonym="Ответственный за бухгалтерские регистры",Comment=""};
    }
}
