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
    [Table("PeremeshchenyeNMA")]
    [Description1C8(Name = "ПеремещениеНМА", Comment = "(Общ)", Synonym = "Перемещение НМА")]
    public class ПеремещениеНМА:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "МОЛОрганизации", Comment = "(Регл)", Synonym = "МОЛ")]
        public Catalogs.ФизическиеЛица МОЛОрганизации {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НематериальныеАктивы", Comment = "(Общ)", Synonym = "Нематериальные активы")]
        public List<ПеремещениеНМА_НематериальныеАктивы> ПеремещениеНМАНематериальныеАктивы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НематериальныеАктивы", Comment = "(Общ)", Synonym = "Нематериальные активы")]
    [Table("PeremeshchenyeNMA_NemateryalnyeAktyvy")]
    public class ПеремещениеНМА_НематериальныеАктивы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Общ)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
    }
}
