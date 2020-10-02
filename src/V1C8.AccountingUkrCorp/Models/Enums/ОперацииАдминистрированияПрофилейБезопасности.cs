using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОперацииАдминистрированияПрофилейБезопасности", Comment = "", Synonym = "Операции администрирования профилей безопасности")]
    public class ОперацииАдминистрированияПрофилейБезопасности:EnumItem
    {
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Создание = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Создание",Synonym="Создание",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Назначение = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Назначение",Synonym="Назначение",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Обновление = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Обновление",Synonym="Обновление",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности Удаление = new ОперацииАдминистрированияПрофилейБезопасности{Name= "Удаление",Synonym="Удаление",Comment=""};
        public static readonly ОперацииАдминистрированияПрофилейБезопасности УдалениеНазначения = new ОперацииАдминистрированияПрофилейБезопасности{Name= "УдалениеНазначения",Synonym="Удаление назначения",Comment=""};
    }
}
