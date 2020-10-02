using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоКолонкиУпрощенногоРасчета", Comment = "", Synonym = "Устарело колонки упрощенного расчета")]
    public class УстарелоКолонкиУпрощенногоРасчета:EnumItem
    {
        public static readonly УстарелоКолонкиУпрощенногоРасчета Оклад = new УстарелоКолонкиУпрощенногоРасчета{Name= "Оклад",Synonym="Оклад",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Отпускные = new УстарелоКолонкиУпрощенногоРасчета{Name= "Отпускные",Synonym="Отпускные",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета БольничныеПредприятие = new УстарелоКолонкиУпрощенногоРасчета{Name= "БольничныеПредприятие",Synonym="Больничные предприятие",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета БольничныеФСС = new УстарелоКолонкиУпрощенногоРасчета{Name= "БольничныеФСС",Synonym="Больничные ФСС",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Индексация = new УстарелоКолонкиУпрощенногоРасчета{Name= "Индексация",Synonym="Индексация",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата1 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата1",Synonym="Доплата1",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата2 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата2",Synonym="Доплата2",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата3 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата3",Synonym="Доплата3",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата4 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата4",Synonym="Доплата4",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата5 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата5",Synonym="Доплата5",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата6 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата6",Synonym="Доплата6",Comment=""};
    }
}
