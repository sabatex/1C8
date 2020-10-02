using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КомпенсацияУдержаниеОтпускаПриУвольнении", Comment = "", Synonym = "Компенсация (удержание) отпуска при увольнении")]
    public class КомпенсацияУдержаниеОтпускаПриУвольнении:EnumItem
    {
        public static readonly КомпенсацияУдержаниеОтпускаПриУвольнении НеИспользовать = new КомпенсацияУдержаниеОтпускаПриУвольнении{Name= "НеИспользовать",Synonim="Не использовать",Comment=""};
        public static readonly КомпенсацияУдержаниеОтпускаПриУвольнении КомпенсироватьНеИспользованные = new КомпенсацияУдержаниеОтпускаПриУвольнении{Name= "КомпенсироватьНеИспользованные",Synonim="Компенсировать неиспользованный отпуск",Comment=""};
        public static readonly КомпенсацияУдержаниеОтпускаПриУвольнении УдержатьЗаИспользованныеАвансом = new КомпенсацияУдержаниеОтпускаПриУвольнении{Name= "УдержатьЗаИспользованныеАвансом",Synonim="Удержать за использованный авансом отпуск",Comment=""};
    }
}
