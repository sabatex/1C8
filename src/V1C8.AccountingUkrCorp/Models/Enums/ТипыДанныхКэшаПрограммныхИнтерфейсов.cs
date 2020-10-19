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
    [Table("TypyDannykhKeshaProhrammnykhYnterfeisov")]
    [Description1C8(Name = "ТипыДанныхКэшаПрограммныхИнтерфейсов", Comment = "", Synonym = "Типы данных кэша программных интерфейсов")]
    public class ТипыДанныхКэшаПрограммныхИнтерфейсов:EnumItem
    {
        public static readonly ТипыДанныхКэшаПрограммныхИнтерфейсов ОписаниеWebСервиса = new ТипыДанныхКэшаПрограммныхИнтерфейсов{Name= "ОписаниеWebСервиса",Synonym="Описание web-сервиса",Comment=""};
        public static readonly ТипыДанныхКэшаПрограммныхИнтерфейсов ВерсииИнтерфейса = new ТипыДанныхКэшаПрограммныхИнтерфейсов{Name= "ВерсииИнтерфейса",Synonym="Версии интерфейса",Comment=""};
    }
}
