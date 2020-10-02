using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииУдержаний", Comment = "", Synonym = "Категории удержаний")]
    public class КатегорииУдержаний:EnumItem
    {
        public static readonly КатегорииУдержаний ПрофсоюзныеВзносы = new КатегорииУдержаний{Name= "ПрофсоюзныеВзносы",Synonim="Профсоюзные взносы",Comment=""};
        public static readonly КатегорииУдержаний Алименты = new КатегорииУдержаний{Name= "Алименты",Synonim="Алименты",Comment=""};
        public static readonly КатегорииУдержаний ИсполнительныйЛист = new КатегорииУдержаний{Name= "ИсполнительныйЛист",Synonim="Исполнительный лист",Comment=""};
        public static readonly КатегорииУдержаний ПочтовыйСбор = new КатегорииУдержаний{Name= "ПочтовыйСбор",Synonim="Почтовый сбор",Comment=""};
        public static readonly КатегорииУдержаний Прочее = new КатегорииУдержаний{Name= "Прочее",Synonim="Прочее",Comment=""};
        public static readonly КатегорииУдержаний ВознаграждениеПлатежногоАгента = new КатегорииУдержаний{Name= "ВознаграждениеПлатежногоАгента",Synonim="Вознаграждение платежного агента",Comment=""};
        public static readonly КатегорииУдержаний УдержаниеЗаНеотработанныеДниОтпуска = new КатегорииУдержаний{Name= "УдержаниеЗаНеотработанныеДниОтпуска",Synonim="Удержание за неотработанные дни отпуска",Comment=""};
        public static readonly КатегорииУдержаний ДСВ = new КатегорииУдержаний{Name= "ДСВ",Synonim="ѳ(не украинский) Дополнительные страховые взносы на накопительную часть пенсии",Comment=""};
        public static readonly КатегорииУдержаний ДобровольныеВзносыВНПФ = new КатегорииУдержаний{Name= "ДобровольныеВзносыВНПФ",Synonim="ѳ(не украинский) Добровольные взносы в НПФ",Comment=""};
        public static readonly КатегорииУдержаний ПрочееУдержаниеВПользуТретьихЛиц = new КатегорииУдержаний{Name= "ПрочееУдержаниеВПользуТретьихЛиц",Synonim="Прочее удержание в пользу третьих лиц",Comment=""};
        public static readonly КатегорииУдержаний УдержаниеВСчетРасчетовПоПрочимОперациям = new КатегорииУдержаний{Name= "УдержаниеВСчетРасчетовПоПрочимОперациям",Synonim="Удержание в счет расчетов по прочим операциям",Comment=""};
        public static readonly КатегорииУдержаний ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска = new КатегорииУдержаний{Name= "ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска",Synonim="Удержание за неотработанные дни отпуска (сохраняемое денежное содержание)",Comment=""};
        public static readonly КатегорииУдержаний ОбязательстваПоУченическомуДоговору = new КатегорииУдержаний{Name= "ОбязательстваПоУченическомуДоговору",Synonim="ѳ(не украинский) Обязательства по ученическому договору",Comment=""};
    }
}
