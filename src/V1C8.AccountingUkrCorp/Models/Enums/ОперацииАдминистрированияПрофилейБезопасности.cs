using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОперацииАдминистрированияПрофилейБезопасности", Comment = "", Synonym = "Операции администрирования профилей безопасности")]
    public class ОперацииАдминистрированияПрофилейБезопасности:EnumItem
    {
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Создание = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Создание",Synonim="Создание",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Назначение = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Назначение",Synonim="Назначение",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Обновление = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Обновление",Synonim="Обновление",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Удаление = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Удаление",Synonim="Удаление",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности УдалениеНазначения = new ОперацииАдминистрированияПрофилейБезопасности{Name= "УдалениеНазначения",Synonim="Удаление назначения",Comment=""};
    }
}
