using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыСкладов", Comment = "", Synonym = "Типы складов")]
    public enum ТипыСкладов
    {
        [Description1C8(Name = "ОптовыйСклад", Comment = "Оптовый склад", Synonym = "Оптовый склад")]
        ОптовыйСклад,
        [Description1C8(Name = "РозничныйМагазин", Comment = "Розничный", Synonym = "Розничный магазин")]
        РозничныйМагазин,
        [Description1C8(Name = "НеавтоматизированнаяТорговаяТочка", Comment = "Неавтоматизированная торговая точка", Synonym = "Неавтоматизированная торговая точка")]
        НеавтоматизированнаяТорговаяТочка
    }
}
