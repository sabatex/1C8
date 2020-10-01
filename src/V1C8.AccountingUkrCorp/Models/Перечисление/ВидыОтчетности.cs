using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОтчетности", Comment = "(Общ)", Synonym = "Виды отчетности")]
    public enum ВидыОтчетности
    {
        [Description1C8(Name = "РегламентированнаяОтчетность", Comment = "(Регл)", Synonym = "Регламентированная отчетность")]
        РегламентированнаяОтчетность,
        [Description1C8(Name = "ОтчетностьПоМСФО", Comment = "(Упр)", Synonym = "Отчетность по МСФО")]
        ОтчетностьПоМСФО
    }
}
