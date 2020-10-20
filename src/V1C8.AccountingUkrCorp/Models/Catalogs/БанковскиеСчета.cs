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
    [Table("BankovskyeScheta")]
    [Description1C8(Name = "БанковскиеСчета", Comment = "(Общ)", Synonym = "Банковские счета")]
    public class БанковскиеСчета
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "НомерСчета", Comment = "", Synonym = "Номер счета")]
    [StringLength(34)]
    public string НомерСчета {get; set;}
    [Description1C8(Name = "Банк", Comment = "(Общ)", Synonym = "Банк")]
    public Catalogs.Банки Банк {get; set;}
    [Description1C8(Name = "Валютный", Comment = "", Synonym = "Валютный")]
    public bool Валютный {get; set;}
    [Description1C8(Name = "ВалютаДенежныхСредств", Comment = "(Общ) Валюта, в которой хранятся денежные средства", Synonym = "Валюта денежных средств")]
    public Catalogs.Валюты ВалютаДенежныхСредств {get; set;}
    [Description1C8(Name = "НомерИДатаРазрешения", Comment = "(Регл) Номер и дата разрешения открытия счета", Synonym = "Номер и дата разрешения")]
    [StringLength(30)]
    public string НомерИДатаРазрешения {get; set;}
    [Description1C8(Name = "ДатаОткрытия", Comment = "(Общ) Дата открытия счета", Synonym = "Дата открытия")]
    public DateTime ДатаОткрытия {get; set;}
    [Description1C8(Name = "ДатаЗакрытия", Comment = "(Общ) Дата закрытия счета", Synonym = "Дата закрытия")]
    public DateTime ДатаЗакрытия {get; set;}
    [Description1C8(Name = "ВидСчета", Comment = "(Общ) Расчетный, депозитный, ссудный, иной", Synonym = "Вид счета")]
    [StringLength(15)]
    public string ВидСчета {get; set;}
    [Description1C8(Name = "ТекстНазначения", Comment = "(Общ) Текст назначения платежа", Synonym = "Текст назначения")]
    [StringLength(250)]
    public string ТекстНазначения {get; set;}
    [Description1C8(Name = "СуммаБезКопеек", Comment = "(Общ) Указывать сумму без копеек, если она в целых гривнях", Synonym = "Сумма без копеек")]
    public bool СуммаБезКопеек {get; set;}
    [Description1C8(Name = "НомерСчетаУстаревший", Comment = "", Synonym = "Номер счета (устар.)")]
    [StringLength(20)]
    public string НомерСчетаУстаревший {get; set;}
    #endregion реквізити
    }
}
