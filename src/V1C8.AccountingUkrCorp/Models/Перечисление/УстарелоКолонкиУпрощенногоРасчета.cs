using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоКолонкиУпрощенногоРасчета", Comment = "", Synonym = "Устарело колонки упрощенного расчета")]
    public enum УстарелоКолонкиУпрощенногоРасчета
    {
        [Description1C8(Name = "Оклад", Comment = "", Synonym = "Оклад")]
        Оклад,
        [Description1C8(Name = "Отпускные", Comment = "", Synonym = "Отпускные")]
        Отпускные,
        [Description1C8(Name = "БольничныеПредприятие", Comment = "", Synonym = "Больничные предприятие")]
        БольничныеПредприятие,
        [Description1C8(Name = "БольничныеФСС", Comment = "", Synonym = "Больничные ФСС")]
        БольничныеФСС,
        [Description1C8(Name = "Индексация", Comment = "", Synonym = "Индексация")]
        Индексация,
        [Description1C8(Name = "Доплата1", Comment = "", Synonym = "Доплата1")]
        Доплата1,
        [Description1C8(Name = "Доплата2", Comment = "", Synonym = "Доплата2")]
        Доплата2,
        [Description1C8(Name = "Доплата3", Comment = "", Synonym = "Доплата3")]
        Доплата3,
        [Description1C8(Name = "Доплата4", Comment = "", Synonym = "Доплата4")]
        Доплата4,
        [Description1C8(Name = "Доплата5", Comment = "", Synonym = "Доплата5")]
        Доплата5,
        [Description1C8(Name = "Доплата6", Comment = "", Synonym = "Доплата6")]
        Доплата6
    }
}
