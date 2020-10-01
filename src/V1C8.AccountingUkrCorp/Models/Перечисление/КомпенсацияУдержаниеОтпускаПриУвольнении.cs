using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КомпенсацияУдержаниеОтпускаПриУвольнении", Comment = "", Synonym = "Компенсация (удержание) отпуска при увольнении")]
    public enum КомпенсацияУдержаниеОтпускаПриУвольнении
    {
        [Description1C8(Name = "НеИспользовать", Comment = "", Synonym = "Не использовать")]
        НеИспользовать,
        [Description1C8(Name = "КомпенсироватьНеИспользованные", Comment = "", Synonym = "Компенсировать неиспользованный отпуск")]
        КомпенсироватьНеИспользованные,
        [Description1C8(Name = "УдержатьЗаИспользованныеАвансом", Comment = "", Synonym = "Удержать за использованный авансом отпуск")]
        УдержатьЗаИспользованныеАвансом
    }
}
