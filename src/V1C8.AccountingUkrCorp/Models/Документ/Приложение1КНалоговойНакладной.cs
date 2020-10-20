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
    [Table("Prylozhenye1KNalohovoiNakladnoi")]
    [Description1C8(Name = "Приложение1КНалоговойНакладной", Comment = "(Регл)", Synonym = "Приложение 1 к налоговой накладной")]
    public class Приложение1КНалоговойНакладной:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПриложение1КНалоговойНакладной ВидОперации {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "(Общ)", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "(Общ)", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СуммаНДСДокумента", Comment = "(Общ) Сумма НДС в валюте документа", Synonym = "Сумма НДС документа")]
        // Format 15.2
        public decimal СуммаНДСДокумента {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "НалоговаяНакладная", Comment = "", Synonym = "Налоговая накладная")]
        public Документ.НалоговаяНакладная НалоговаяНакладная {get; set;}
        [Description1C8(Name = "КтоВыписалНалоговуюНакладную", Comment = "", Synonym = "Кто выписал налоговую накладную")]
        public Catalogs.ФизическиеЛица КтоВыписалНалоговуюНакладную {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<Приложение1КНалоговойНакладной_Товары> Приложение1КНалоговойНакладнойТовары {get;set;}
        [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
        public List<Приложение1КНалоговойНакладной_Услуги> Приложение1КНалоговойНакладнойУслуги {get;set;}
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<Приложение1КНалоговойНакладной_ОС> Приложение1КНалоговойНакладнойОС {get;set;}
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<Приложение1КНалоговойНакладной_НМА> Приложение1КНалоговойНакладнойНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("Prylozhenye1KNalohovoiNakladnoi_Tovary")]
    public class Приложение1КНалоговойНакладной_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "КоличествоОтгружено", Comment = "(Общ)", Synonym = "Количество отгружено")]
        // Format 15.3
        public decimal КоличествоОтгружено {get; set;}
        [Description1C8(Name = "КоличествоОсталось", Comment = "(Общ)", Synonym = "Количество осталось")]
        // Format 15.3
        public decimal КоличествоОсталось {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "СуммаБезСкидки", Comment = "(Общ)", Synonym = "Сумма без скидки")]
        // Format 15.2
        public decimal СуммаБезСкидки {get; set;}
        [Description1C8(Name = "СуммаСкидки", Comment = "(Общ)", Synonym = "Сумма скидки")]
        // Format 15.2
        public decimal СуммаСкидки {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
    }
    [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
    [Table("Prylozhenye1KNalohovoiNakladnoi_Usluhy")]
    public class Приложение1КНалоговойНакладной_Услуги
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Содержание", Comment = "(Общ)", Synonym = "Содержание услуги, доп. сведения")]
        [StringLength(1000)]
        public string Содержание {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "КоличествоОтгружено", Comment = "(Общ)", Synonym = "Количество отгружено")]
        // Format 15.3
        public decimal КоличествоОтгружено {get; set;}
        [Description1C8(Name = "КоличествоОсталось", Comment = "(Общ)", Synonym = "Количество осталось")]
        // Format 15.3
        public decimal КоличествоОсталось {get; set;}
        [Description1C8(Name = "СуммаБезСкидки", Comment = "(Общ)", Synonym = "Сумма без скидки")]
        // Format 15.2
        public decimal СуммаБезСкидки {get; set;}
        [Description1C8(Name = "СуммаСкидки", Comment = "(Общ)", Synonym = "Сумма скидки")]
        // Format 15.2
        public decimal СуммаСкидки {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("Prylozhenye1KNalohovoiNakladnoi_OS")]
    public class Приложение1КНалоговойНакладной_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "КоличествоОтгружено", Comment = "(Общ)", Synonym = "Количество отгружено")]
        // Format 15.3
        public decimal КоличествоОтгружено {get; set;}
        [Description1C8(Name = "КоличествоОсталось", Comment = "(Общ)", Synonym = "Количество осталось")]
        // Format 15.3
        public decimal КоличествоОсталось {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("Prylozhenye1KNalohovoiNakladnoi_NMA")]
    public class Приложение1КНалоговойНакладной_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Регл)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "КоличествоОтгружено", Comment = "(Общ)", Synonym = "Количество отгружено")]
        // Format 15.3
        public decimal КоличествоОтгружено {get; set;}
        [Description1C8(Name = "КоличествоОсталось", Comment = "(Общ)", Synonym = "Количество осталось")]
        // Format 15.3
        public decimal КоличествоОсталось {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
    }
}
