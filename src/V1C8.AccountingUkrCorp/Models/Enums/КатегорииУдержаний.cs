using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("KatehoryyUderzhanyi")]
    [Description1C8(Name = "КатегорииУдержаний", Comment = "", Synonym = "Категории удержаний")]
    public class КатегорииУдержаний:EnumItem
    {
        public static readonly КатегорииУдержаний ПрофсоюзныеВзносы = new КатегорииУдержаний{Name= "ПрофсоюзныеВзносы",Synonym="Профсоюзные взносы",Comment=""};
        public static readonly КатегорииУдержаний Алименты = new КатегорииУдержаний{Name= "Алименты",Synonym="Алименты",Comment=""};
        public static readonly КатегорииУдержаний ИсполнительныйЛист = new КатегорииУдержаний{Name= "ИсполнительныйЛист",Synonym="Исполнительный лист",Comment=""};
        public static readonly КатегорииУдержаний ПочтовыйСбор = new КатегорииУдержаний{Name= "ПочтовыйСбор",Synonym="Почтовый сбор",Comment=""};
        public static readonly КатегорииУдержаний Прочее = new КатегорииУдержаний{Name= "Прочее",Synonym="Прочее",Comment=""};
        public static readonly КатегорииУдержаний ВознаграждениеПлатежногоАгента = new КатегорииУдержаний{Name= "ВознаграждениеПлатежногоАгента",Synonym="Вознаграждение платежного агента",Comment=""};
        public static readonly КатегорииУдержаний УдержаниеЗаНеотработанныеДниОтпуска = new КатегорииУдержаний{Name= "УдержаниеЗаНеотработанныеДниОтпуска",Synonym="Удержание за неотработанные дни отпуска",Comment=""};
        public static readonly КатегорииУдержаний ДСВ = new КатегорииУдержаний{Name= "ДСВ",Synonym="ѳ(не украинский) Дополнительные страховые взносы на накопительную часть пенсии",Comment=""};
        public static readonly КатегорииУдержаний ДобровольныеВзносыВНПФ = new КатегорииУдержаний{Name= "ДобровольныеВзносыВНПФ",Synonym="ѳ(не украинский) Добровольные взносы в НПФ",Comment=""};
        public static readonly КатегорииУдержаний ПрочееУдержаниеВПользуТретьихЛиц = new КатегорииУдержаний{Name= "ПрочееУдержаниеВПользуТретьихЛиц",Synonym="Прочее удержание в пользу третьих лиц",Comment=""};
        public static readonly КатегорииУдержаний УдержаниеВСчетРасчетовПоПрочимОперациям = new КатегорииУдержаний{Name= "УдержаниеВСчетРасчетовПоПрочимОперациям",Synonym="Удержание в счет расчетов по прочим операциям",Comment=""};
        public static readonly КатегорииУдержаний ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска = new КатегорииУдержаний{Name= "ДенежноеСодержаниеУдержаниеЗаНеотработанныеДниОтпуска",Synonym="Удержание за неотработанные дни отпуска (сохраняемое денежное содержание)",Comment=""};
        public static readonly КатегорииУдержаний ОбязательстваПоУченическомуДоговору = new КатегорииУдержаний{Name= "ОбязательстваПоУченическомуДоговору",Synonym="ѳ(не украинский) Обязательства по ученическому договору",Comment=""};
    }
}
