using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("PokupkaProdazhaValiuty")]
    [Description1C8(Name = "ПокупкаПродажаВалюты", Comment = "(Общ)", Synonym = "Покупка/продажа валюты")]
    public class ПокупкаПродажаВалюты:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПокупкаПродажаВалюты ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
        public Catalogs.Контрагенты Банк {get; set;}
        [Description1C8(Name = "Валюта", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты Валюта {get; set;}
        [Description1C8(Name = "СуммаГривневая", Comment = "", Synonym = "Сумма гривневая")]
        // Format 15.2
        public decimal СуммаГривневая {get; set;}
        [Description1C8(Name = "СуммаВалютная", Comment = "", Synonym = "Сумма валютная")]
        // Format 15.2
        public decimal СуммаВалютная {get; set;}
        [Description1C8(Name = "СуммаКомиссионные", Comment = "", Synonym = "Сумма комиссионных")]
        // Format 15.2
        public decimal СуммаКомиссионные {get; set;}
        [Description1C8(Name = "СуммаПенсионный", Comment = "", Synonym = "Сумма отчислений в ПФ")]
        // Format 15.2
        public decimal СуммаПенсионный {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Общая сумма документа")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СчетЗатратКурсоваяРазница", Comment = "(Регл)", Synonym = "Счет затрат по курсовой разнице")]
        public ПланСчетов.Хозрасчетный СчетЗатратКурсоваяРазница {get; set;}
        [Description1C8(Name = "Субконто1ЗатратКурсоваяРазница", Comment = "(Регл)", Synonym = "Субконто затрат 1 (разница курсов)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1ЗатратКурсоваяРазница {get; set;}
        [Description1C8(Name = "Субконто2ЗатратКурсоваяРазница", Comment = "(Регл)", Synonym = "Субконто затрат 2 (разница курсов)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2ЗатратКурсоваяРазница {get; set;}
        [Description1C8(Name = "Субконто3ЗатратКурсоваяРазница", Comment = "(Регл)", Synonym = "Субконто затрат 3 (разница курсов)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3ЗатратКурсоваяРазница {get; set;}
        [Description1C8(Name = "СчетДоходовКурсоваяРазница", Comment = "(Регл)", Synonym = "Счет доходов по курсовой разнице")]
        public ПланСчетов.Хозрасчетный СчетДоходовКурсоваяРазница {get; set;}
        [Description1C8(Name = "Субконто1ДоходовКурсоваяРазница", Comment = "(Регл)", Synonym = "Субконто доходов 1 (разница курсов)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1ДоходовКурсоваяРазница {get; set;}
        [Description1C8(Name = "Субконто2ДоходовКурсоваяРазница", Comment = "(Регл)", Synonym = "Субконто доходов 2 (разница курсов)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2ДоходовКурсоваяРазница {get; set;}
        [Description1C8(Name = "Субконто3ДоходовКурсоваяРазница", Comment = "(Регл)", Synonym = "Субконто доходов 3 (разница курсов)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3ДоходовКурсоваяРазница {get; set;}
        [Description1C8(Name = "СчетЗатратКомиссионные", Comment = "(Регл)", Synonym = "Счет затрат по комиссионным")]
        public ПланСчетов.Хозрасчетный СчетЗатратКомиссионные {get; set;}
        [Description1C8(Name = "Субконто1ЗатратКомиссионные", Comment = "(Регл)", Synonym = "Субконто затрат 1 (комиссионные)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1ЗатратКомиссионные {get; set;}
        [Description1C8(Name = "Субконто2ЗатратКомиссионные", Comment = "(Регл)", Synonym = "Субконто затрат 2 (комиссионные)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2ЗатратКомиссионные {get; set;}
        [Description1C8(Name = "Субконто3ЗатратКомиссионные", Comment = "(Регл)", Synonym = "Субконто затрат 3 (комиссионные)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3ЗатратКомиссионные {get; set;}
        [Description1C8(Name = "СчетЗатратПенсионный", Comment = "(Регл)", Synonym = "Счет затрат по пенсионному фонду")]
        public ПланСчетов.Хозрасчетный СчетЗатратПенсионный {get; set;}
        [Description1C8(Name = "Субконто1ЗатратПенсионный", Comment = "(Регл)", Synonym = "Субконто затрат 1 (пенсионный)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1ЗатратПенсионный {get; set;}
        [Description1C8(Name = "Субконто2ЗатратПенсионный", Comment = "(Регл)", Synonym = "Субконто затрат 2 (пенсионный)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2ЗатратПенсионный {get; set;}
        [Description1C8(Name = "Субконто3ЗатратПенсионный", Comment = "(Регл)", Synonym = "Субконто затрат 3 (пенсионный)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3ЗатратПенсионный {get; set;}
        [Description1C8(Name = "СчетЗатратСебестоимость", Comment = "(Регл)", Synonym = "Счет затрат по себестоимости")]
        public ПланСчетов.Хозрасчетный СчетЗатратСебестоимость {get; set;}
        [Description1C8(Name = "Субконто1ЗатратСебестоимость", Comment = "(Регл)", Synonym = "Субконто затрат 1 (себестоимость)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1ЗатратСебестоимость {get; set;}
        [Description1C8(Name = "Субконто2ЗатратСебестоимость", Comment = "(Регл)", Synonym = "Субконто затрат 2 (себестоимость)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2ЗатратСебестоимость {get; set;}
        [Description1C8(Name = "Субконто3ЗатратСебестоимость", Comment = "(Регл)", Synonym = "Субконто затрат 3 (себестоимость)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3ЗатратСебестоимость {get; set;}
        [Description1C8(Name = "СчетДоходовСебестоимость", Comment = "(Регл)", Synonym = "Счет доходов по себестоимости")]
        public ПланСчетов.Хозрасчетный СчетДоходовСебестоимость {get; set;}
        [Description1C8(Name = "Субконто1ДоходовСебестоимость", Comment = "(Регл)", Synonym = "Субконто доходов 1 (себестоимость)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1ДоходовСебестоимость {get; set;}
        [Description1C8(Name = "Субконто2ДоходовСебестоимость", Comment = "(Регл)", Synonym = "Субконто доходов 2 (себестоимость)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2ДоходовСебестоимость {get; set;}
        [Description1C8(Name = "Субконто3ДоходовСебестоимость", Comment = "(Регл)", Synonym = "Субконто доходов 3 (себестоимость)")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3ДоходовСебестоимость {get; set;}
        [Description1C8(Name = "Заявка", Comment = "", Synonym = "Заявка")]
        public Документ.ЗаявкаНаПокупкуПродажуВалюты Заявка {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
