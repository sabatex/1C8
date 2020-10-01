using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОтветственныеЛицаОрганизаций", Comment = "(Регл)", Synonym = "Ответственные лица организаций")]
    public enum ОтветственныеЛицаОрганизаций
    {
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        Руководитель,
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        ГлавныйБухгалтер,
        [Description1C8(Name = "РуководительКадровойСлужбы", Comment = "", Synonym = "Руководитель кадровой службы")]
        РуководительКадровойСлужбы,
        [Description1C8(Name = "Кассир", Comment = "", Synonym = "Кассир")]
        Кассир,
        [Description1C8(Name = "ОтветственныйЗаБухгалтерскиеРегистры", Comment = "", Synonym = "Ответственный за бухгалтерские регистры")]
        ОтветственныйЗаБухгалтерскиеРегистры
    }
}
