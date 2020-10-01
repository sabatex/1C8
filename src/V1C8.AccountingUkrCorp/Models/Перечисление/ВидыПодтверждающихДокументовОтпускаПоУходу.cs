using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПодтверждающихДокументовОтпускаПоУходу", Comment = "", Synonym = "Виды подтверждающих документов отпуска по уходу")]
    public enum ВидыПодтверждающихДокументовОтпускаПоУходу
    {
        [Description1C8(Name = "СвидетельствоОРождении", Comment = "", Synonym = "Свидетельство о рождении")]
        СвидетельствоОРождении,
        [Description1C8(Name = "РешениеОбУстановленииОпеки", Comment = "", Synonym = "Решение об установлении опеки")]
        РешениеОбУстановленииОпеки,
        [Description1C8(Name = "ИнойДокументПодтверждающийРождениеРебенка", Comment = "", Synonym = "Иной документ подтверждающий рождение ребенка")]
        ИнойДокументПодтверждающийРождениеРебенка,
        [Description1C8(Name = "СвидетельствоОСмерти", Comment = "", Synonym = "Свидетельство о смерти")]
        СвидетельствоОСмерти
    }
}
