using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоКолонкиУпрощенногоРасчета", Comment = "", Synonym = "Устарело колонки упрощенного расчета")]
    public class УстарелоКолонкиУпрощенногоРасчета:EnumItem
    {
        public static readonly УстарелоКолонкиУпрощенногоРасчета Оклад = new УстарелоКолонкиУпрощенногоРасчета{Name= "Оклад",Synonim="Оклад",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Отпускные = new УстарелоКолонкиУпрощенногоРасчета{Name= "Отпускные",Synonim="Отпускные",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета БольничныеПредприятие = new УстарелоКолонкиУпрощенногоРасчета{Name= "БольничныеПредприятие",Synonim="Больничные предприятие",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета БольничныеФСС = new УстарелоКолонкиУпрощенногоРасчета{Name= "БольничныеФСС",Synonim="Больничные ФСС",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Индексация = new УстарелоКолонкиУпрощенногоРасчета{Name= "Индексация",Synonim="Индексация",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата1 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата1",Synonim="Доплата1",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата2 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата2",Synonim="Доплата2",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата3 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата3",Synonim="Доплата3",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата4 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата4",Synonim="Доплата4",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата5 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата5",Synonim="Доплата5",Comment=""};
        public static readonly УстарелоКолонкиУпрощенногоРасчета Доплата6 = new УстарелоКолонкиУпрощенногоРасчета{Name= "Доплата6",Synonim="Доплата6",Comment=""};
    }
}
