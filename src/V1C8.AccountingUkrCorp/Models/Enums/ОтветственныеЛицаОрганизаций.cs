using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОтветственныеЛицаОрганизаций", Comment = "(Регл)", Synonym = "Ответственные лица организаций")]
    public class ОтветственныеЛицаОрганизаций:EnumItem
    {
        public static readonly ОтветственныеЛицаОрганизаций Руководитель = new ОтветственныеЛицаОрганизаций{Name= "Руководитель",Synonim="Руководитель",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций ГлавныйБухгалтер = new ОтветственныеЛицаОрганизаций{Name= "ГлавныйБухгалтер",Synonim="Главный бухгалтер",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций РуководительКадровойСлужбы = new ОтветственныеЛицаОрганизаций{Name= "РуководительКадровойСлужбы",Synonim="Руководитель кадровой службы",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций Кассир = new ОтветственныеЛицаОрганизаций{Name= "Кассир",Synonim="Кассир",Comment=""};
        public static readonly ОтветственныеЛицаОрганизаций ОтветственныйЗаБухгалтерскиеРегистры = new ОтветственныеЛицаОрганизаций{Name= "ОтветственныйЗаБухгалтерскиеРегистры",Synonim="Ответственный за бухгалтерские регистры",Comment=""};
    }
}
