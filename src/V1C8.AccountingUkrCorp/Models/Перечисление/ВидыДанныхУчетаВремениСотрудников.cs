using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДанныхУчетаВремениСотрудников", Comment = "", Synonym = "Виды данных учета времени сотрудников")]
    public enum ВидыДанныхУчетаВремениСотрудников
    {
        [Description1C8(Name = "ДанныеОбщихГрафиков", Comment = "", Synonym = "Данные общих графиков")]
        ДанныеОбщихГрафиков,
        [Description1C8(Name = "ДанныеИндивидуальныхГрафиков", Comment = "", Synonym = "Данные индивидуальных графиков")]
        ДанныеИндивидуальныхГрафиков,
        [Description1C8(Name = "ДанныеТабельногоУчета", Comment = "", Synonym = "Данные табельного учета")]
        ДанныеТабельногоУчета,
        [Description1C8(Name = "ДанныеОперативногоУчета", Comment = "", Synonym = "Данные оперативного учета")]
        ДанныеОперативногоУчета,
        [Description1C8(Name = "ДанныеВнутрисменныхНеявок", Comment = "", Synonym = "Данные внутрисменных неявок")]
        ДанныеВнутрисменныхНеявок,
        [Description1C8(Name = "ВытесняемоеПлановоеВремя", Comment = "", Synonym = "Вытесняемое плановое время")]
        ВытесняемоеПлановоеВремя,
        [Description1C8(Name = "ДополнительноеВнутрисменноеВремя", Comment = "", Synonym = "Дополнительное внутрисменное время")]
        ДополнительноеВнутрисменноеВремя,
        [Description1C8(Name = "СводныеДанные", Comment = "", Synonym = "Сводные данные")]
        СводныеДанные
    }
}
