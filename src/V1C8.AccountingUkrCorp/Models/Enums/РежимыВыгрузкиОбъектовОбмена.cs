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
    [Table("RezhymyVyhruzkyObektovObmena")]
    [Description1C8(Name = "РежимыВыгрузкиОбъектовОбмена", Comment = "", Synonym = "Режимы выгрузки объектов обмена")]
    public class РежимыВыгрузкиОбъектовОбмена:EnumItem
    {
        public static readonly РежимыВыгрузкиОбъектовОбмена ВыгружатьВсегда = new РежимыВыгрузкиОбъектовОбмена{Name= "ВыгружатьВсегда",Synonym="Выгружать всегда",Comment="Выгрузка без использования фильтров"};
        public static readonly РежимыВыгрузкиОбъектовОбмена ВыгружатьПоУсловию = new РежимыВыгрузкиОбъектовОбмена{Name= "ВыгружатьПоУсловию",Synonym="Выгружать по условию",Comment="Выгрузка с использованием фильтров"};
        public static readonly РежимыВыгрузкиОбъектовОбмена ВыгружатьПриНеобходимости = new РежимыВыгрузкиОбъектовОбмена{Name= "ВыгружатьПриНеобходимости",Synonym="Выгружать при необходимости",Comment="Выгрузка без использования фильтров, но с контролем ссылочной целостности выгружаемых данных"};
        public static readonly РежимыВыгрузкиОбъектовОбмена ВыгружатьВручную = new РежимыВыгрузкиОбъектовОбмена{Name= "ВыгружатьВручную",Synonym="Выгружать вручную",Comment="В этом режиме изменения объектов не регистрируются автоматически (через подписки на события); объекты регистрируются к выгрузке вручную пользователем и выгружаются только, если соответствуют фильтру, установленному на узле, для которого выполняется выгруз"};
        public static readonly РежимыВыгрузкиОбъектовОбмена НеВыгружать = new РежимыВыгрузкиОбъектовОбмена{Name= "НеВыгружать",Synonym="Не выгружать",Comment="В этом режиме изменения объектов не регистрируются автоматически (через подписки на события) и не выгружаются, даже если изменения объектов были зарегистрированы вручную пользователем."};
    }
}
