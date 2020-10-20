using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("SertyfykatyKliucheiЕlektronnoiPodpysyYShyfrovanyia")]
    [Description1C8(Name = "СертификатыКлючейЭлектроннойПодписиИШифрования", Comment = "", Synonym = "Сертификаты ключей электронной подписи и шифрования")]
    public class СертификатыКлючейЭлектроннойПодписиИШифрования:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "КомуВыдан", Comment = "", Synonym = "Кому выдан")]
    [StringLength(430)]
    public string КомуВыдан {get; set;}
    [Description1C8(Name = "Фирма", Comment = "", Synonym = "Фирма")]
    [StringLength(100)]
    public string Фирма {get; set;}
    [Description1C8(Name = "Фамилия", Comment = "", Synonym = "Фамилия")]
    [StringLength(100)]
    public string Фамилия {get; set;}
    [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
    [StringLength(100)]
    public string Имя {get; set;}
    [Description1C8(Name = "Отчество", Comment = "", Synonym = "Отчество")]
    [StringLength(100)]
    public string Отчество {get; set;}
    [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
    [StringLength(100)]
    public string Должность {get; set;}
    [Description1C8(Name = "КемВыдан", Comment = "", Synonym = "Кем выдан")]
    [StringLength(100)]
    public string КемВыдан {get; set;}
    [Description1C8(Name = "ДействителенДо", Comment = "", Synonym = "Действителен до")]
    public DateTime ДействителенДо {get; set;}
    [Description1C8(Name = "Подписание", Comment = "", Synonym = "Подписание")]
    public bool Подписание {get; set;}
    [Description1C8(Name = "Шифрование", Comment = "", Synonym = "Шифрование")]
    public bool Шифрование {get; set;}
    [Description1C8(Name = "Отпечаток", Comment = "", Synonym = "Отпечаток")]
    [StringLength(28)]
    public string Отпечаток {get; set;}
    [Description1C8(Name = "ДанныеСертификата", Comment = "Двоичные данные сертификата", Synonym = "Данные сертификата")]
    // Сховище значень
    public byte[] ДанныеСертификата {get; set;}
    [Description1C8(Name = "Программа", Comment = "", Synonym = "Программа")]
    public Catalogs.ПрограммыЭлектроннойПодписиИШифрования Программа {get; set;}
    [Description1C8(Name = "Отозван", Comment = "", Synonym = "Отозван")]
    public bool Отозван {get; set;}
    [Description1C8(Name = "УсиленнаяЗащитаЗакрытогоКлюча", Comment = "", Synonym = "Усиленная защита закрытого ключа")]
    public bool УсиленнаяЗащитаЗакрытогоКлюча {get; set;}
    [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
    public Catalogs.Организации Организация {get; set;}
    [Description1C8(Name = "Пользователь", Comment = "", Synonym = "Пользователь")]
    public Catalogs.Пользователи Пользователь {get; set;}
    [Description1C8(Name = "ПользовательОповещенОСрокеДействия", Comment = "", Synonym = "Пользователь оповещен о сроке действия")]
    public bool ПользовательОповещенОСрокеДействия {get; set;}
    [Description1C8(Name = "Добавил", Comment = "", Synonym = "Добавил")]
    public Catalogs.Пользователи Добавил {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
