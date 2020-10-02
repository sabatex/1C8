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
        public static readonly ВидыДополнительныхОтчетовИОбработок ДополнительнаяОбработка = new ВидыДополнительныхОтчетовИОбработок{Name= "ДополнительнаяОбработка",Synonym="Дополнительная обработка",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ДополнительныйОтчет = new ВидыДополнительныхОтчетовИОбработок{Name= "ДополнительныйОтчет",Synonym="Дополнительный отчет",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ЗаполнениеОбъекта = new ВидыДополнительныхОтчетовИОбработок{Name= "ЗаполнениеОбъекта",Synonym="Заполнение объекта",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок Отчет = new ВидыДополнительныхОтчетовИОбработок{Name= "Отчет",Synonym="Отчет",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ПечатнаяФорма = new ВидыДополнительныхОтчетовИОбработок{Name= "ПечатнаяФорма",Synonym="Печатная форма",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок СозданиеСвязанныхОбъектов = new ВидыДополнительныхОтчетовИОбработок{Name= "СозданиеСвязанныхОбъектов",Synonym="Создание связанных объектов",Comment=""};
        public static readonly ВидыДополнительныхОтчетовИОбработок ШаблонСообщения = new ВидыДополнительныхОтчетовИОбработок{Name= "ШаблонСообщения",Synonym="Шаблон сообщения",Comment=""};
    }
}
