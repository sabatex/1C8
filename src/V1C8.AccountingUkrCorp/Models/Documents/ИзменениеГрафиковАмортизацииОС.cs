using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("YzmenenyeHrafykovAmortyzatsyyOS")]
    [Description1C8(Name = "ИзменениеГрафиковАмортизацииОС", Comment = "(Общ)", Synonym = "Изменение графиков амортизации ОС")]
    public class ИзменениеГрафиковАмортизацииОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ГрафикАмортизации", Comment = "(Общ)", Synonym = "График амортизации")]
        public Catalogs.ГодовыеГрафикиАмортизацииОС ГрафикАмортизации {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Регл)", Synonym = "Событие")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
        public List<ИзменениеГрафиковАмортизацииОС_ОС> ИзменениеГрафиковАмортизацииОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
    [Table("YzmenenyeHrafykovAmortyzatsyyOS_OS")]
    public class ИзменениеГрафиковАмортизацииОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
    }
}
