using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПриложение1КНалоговойНакладной", Comment = "(Общ)", Synonym = "Виды операций документа 'Приложение 1 к налоговой накладной'")]
    public enum ВидыОперацийПриложение1КНалоговойНакладной
    {
        [Description1C8(Name = "ОблагаемыеОперации", Comment = "", Synonym = "Операции, облагаемые НДС")]
        ОблагаемыеОперации,
        [Description1C8(Name = "ОсвобожденныеОперации", Comment = "Операции, освобожденные от НДС (п.5)", Synonym = "Операции, освобожденные от  НДС")]
        ОсвобожденныеОперации,
        [Description1C8(Name = "НеНДСОперации", Comment = "Операции, не объекты налогообложения по НДС (п. 3.2)", Synonym = "Операции, не являющиеся объектом налогообложения")]
        НеНДСОперации
    }
}
