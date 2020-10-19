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
    [Table("VydyOperatsyiPrylozhenye1KNalohovoiNakladnoi")]
    [Description1C8(Name = "ВидыОперацийПриложение1КНалоговойНакладной", Comment = "(Общ)", Synonym = "Виды операций документа 'Приложение 1 к налоговой накладной'")]
    public class ВидыОперацийПриложение1КНалоговойНакладной:EnumItem
    {
        public static readonly ВидыОперацийПриложение1КНалоговойНакладной ОблагаемыеОперации = new ВидыОперацийПриложение1КНалоговойНакладной{Name= "ОблагаемыеОперации",Synonym="Операции, облагаемые НДС",Comment=""};
        public static readonly ВидыОперацийПриложение1КНалоговойНакладной ОсвобожденныеОперации = new ВидыОперацийПриложение1КНалоговойНакладной{Name= "ОсвобожденныеОперации",Synonym="Операции, освобожденные от  НДС",Comment="Операции, освобожденные от НДС (п.5)"};
        public static readonly ВидыОперацийПриложение1КНалоговойНакладной НеНДСОперации = new ВидыОперацийПриложение1КНалоговойНакладной{Name= "НеНДСОперации",Synonym="Операции, не являющиеся объектом налогообложения",Comment="Операции, не объекты налогообложения по НДС (п. 3.2)"};
    }
}
