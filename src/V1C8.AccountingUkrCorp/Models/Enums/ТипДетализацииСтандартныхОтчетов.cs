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
    [Table("TypDetalyzatsyyStandartnykhOtchetov")]
    [Description1C8(Name = "ТипДетализацииСтандартныхОтчетов", Comment = "", Synonym = "Тип детализации стандартных отчетов")]
    public class ТипДетализацииСтандартныхОтчетов:EnumItem
    {
        public static readonly ТипДетализацииСтандартныхОтчетов Элементы = new ТипДетализацииСтандартныхОтчетов{Name= "Элементы",Synonym="Без групп",Comment=""};
        public static readonly ТипДетализацииСтандартныхОтчетов Иерархия = new ТипДетализацииСтандартныхОтчетов{Name= "Иерархия",Synonym="С группами",Comment=""};
        public static readonly ТипДетализацииСтандартныхОтчетов ТолькоИерархия = new ТипДетализацииСтандартныхОтчетов{Name= "ТолькоИерархия",Synonym="Только группы",Comment=""};
    }
}
