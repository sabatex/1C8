using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыСкладов", Comment = "", Synonym = "Типы складов")]
    public class ТипыСкладов:EnumItem
    {
        public static readonly ТипыСкладов ОптовыйСклад = new ТипыСкладов{Name= "ОптовыйСклад",Synonym="Оптовый склад",Comment="Оптовый склад"};
        public static readonly ТипыСкладов РозничныйМагазин = new ТипыСкладов{Name= "РозничныйМагазин",Synonym="Розничный магазин",Comment="Розничный"};
        public static readonly ТипыСкладов НеавтоматизированнаяТорговаяТочка = new ТипыСкладов{Name= "НеавтоматизированнаяТорговаяТочка",Synonym="Неавтоматизированная торговая точка",Comment="Неавтоматизированная торговая точка"};
    }
}
