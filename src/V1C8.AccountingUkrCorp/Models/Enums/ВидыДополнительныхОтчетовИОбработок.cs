using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДополнительныхОтчетовИОбработок", Comment = "", Synonym = "Виды дополнительных отчетов и обработок")]
    public class ВидыДополнительныхОтчетовИОбработок:EnumItem
    {
        public static readonly ВидыДополнительныхОтчетовИОбработок ДополнительнаяОбработка = new ВидыДополнительныхОтчетовИОбработок{Name= "ДополнительнаяОбработка",Synonim="Дополнительная обработка",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ДополнительныйОтчет = new ВидыДополнительныхОтчетовИОбработок{Name= "ДополнительныйОтчет",Synonim="Дополнительный отчет",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ЗаполнениеОбъекта = new ВидыДополнительныхОтчетовИОбработок{Name= "ЗаполнениеОбъекта",Synonim="Заполнение объекта",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок Отчет = new ВидыДополнительныхОтчетовИОбработок{Name= "Отчет",Synonim="Отчет",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ПечатнаяФорма = new ВидыДополнительныхОтчетовИОбработок{Name= "ПечатнаяФорма",Synonim="Печатная форма",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок СозданиеСвязанныхОбъектов = new ВидыДополнительныхОтчетовИОбработок{Name= "СозданиеСвязанныхОбъектов",Synonim="Создание связанных объектов",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ШаблонСообщения = new ВидыДополнительныхОтчетовИОбработок{Name= "ШаблонСообщения",Synonim="Шаблон сообщения",Comment=""};
    }
}
