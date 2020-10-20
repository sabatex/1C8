using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("YzmenenyeSposobovOtrazhenyiaRaskhodovPoAmortyzatsyyOS")]
    [Description1C8(Name = "ИзменениеСпособовОтраженияРасходовПоАмортизацииОС", Comment = "(Общ)", Synonym = "Изменение отражения амортизации ОС")]
    public class ИзменениеСпособовОтраженияРасходовПоАмортизацииОС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходовПоАмортизации", Comment = "(Общ)", Synonym = "Способ отражения расходов по амортизации")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходовПоАмортизации {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Регл)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<ИзменениеСпособовОтраженияРасходовПоАмортизацииОС_ОС> ИзменениеСпособовОтраженияРасходовПоАмортизацииОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("YzmenenyeSposobovOtrazhenyiaRaskhodovPoAmortyzatsyyOS_OS")]
    public class ИзменениеСпособовОтраженияРасходовПоАмортизацииОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
    }
}
