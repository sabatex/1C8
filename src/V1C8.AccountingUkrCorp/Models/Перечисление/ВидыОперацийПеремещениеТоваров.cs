using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПеремещениеТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Перемещение товаров'")]
    public enum ВидыОперацийПеремещениеТоваров
    {
        [Description1C8(Name = "ТоварыПродукция", Comment = "", Synonym = "Товары, продукция")]
        ТоварыПродукция,
        [Description1C8(Name = "Оборудование", Comment = "", Synonym = "Оборудование")]
        Оборудование,
        [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "", Synonym = "Бланки строгого учета")]
        БланкиСтрогогоУчета
    }
}
