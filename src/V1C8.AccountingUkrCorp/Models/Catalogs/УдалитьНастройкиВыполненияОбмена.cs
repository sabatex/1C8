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
    [Table("UdalytNastroikyVypolnenyiaObmena")]
    [Description1C8(Name = "УдалитьНастройкиВыполненияОбмена", Comment = "", Synonym = "(не используется) Настройки выполнения обмена")]
    public class УдалитьНастройкиВыполненияОбмена:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВыполнятьДействияПодПолнымиПравами", Comment = "", Synonym = "Выполнять действия под полными правами")]
        public bool ВыполнятьДействияПодПолнымиПравами {get; set;}
        [Description1C8(Name = "ИспользоватьРегламентныеЗадания", Comment = "", Synonym = "Использовать регламентные задания")]
        public bool ИспользоватьРегламентныеЗадания {get; set;}
        [Description1C8(Name = "РегламентноеЗадание", Comment = "", Synonym = "Регламентное задание")]
        [StringLength(40)]
        public string РегламентноеЗадание {get; set;}
        [Description1C8(Name = "ДинамическиИзменятьИнтервалМеждуОбменами", Comment = "", Synonym = "Динамически изменять интервал между обменами")]
        public bool ДинамическиИзменятьИнтервалМеждуОбменами {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Пользователь")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "КаждыйЗапускПрограммы", Comment = "", Synonym = "Каждый запуск программы")]
        public bool КаждыйЗапускПрограммы {get; set;}
        [Description1C8(Name = "КаждоеЗавершениеРаботыСПрограммой", Comment = "", Synonym = "Каждое завершение работы с программой")]
        public bool КаждоеЗавершениеРаботыСПрограммой {get; set;}
        [Description1C8(Name = "КаталогПроверкиДоступности", Comment = "", Synonym = "Каталог проверки доступности")]
        [StringLength(255)]
        public string КаталогПроверкиДоступности {get; set;}
        [Description1C8(Name = "ВыполнятьОбменПриПоявленииФайла", Comment = "", Synonym = "Выполнять обмен при появлении файла")]
        [StringLength(255)]
        public string ВыполнятьОбменПриПоявленииФайла {get; set;}
        [Description1C8(Name = "КоличествоЭлементовВТранзакцииНаВыгрузкуДанных", Comment = "", Synonym = "Количество элементов в транзакции на выгрузку данных")]
        // Format 10.0
        public long КоличествоЭлементовВТранзакцииНаВыгрузкуДанных {get; set;}
        [Description1C8(Name = "КоличествоЭлементовВТранзакцииНаЗагрузкуДанных", Comment = "", Synonym = "Количество элементов в транзакции на загрузку данных")]
        // Format 10.0
        public long КоличествоЭлементовВТранзакцииНаЗагрузкуДанных {get; set;}
        [Description1C8(Name = "УчетнаяЗаписьОтправкиСообщенияОбОшибке", Comment = "", Synonym = "Учетная запись отправки сообщения об ошибке")]
        [StringLength(10)]
        public string УчетнаяЗаписьОтправкиСообщенияОбОшибке {get; set;}
        [Description1C8(Name = "АдресДляОтправкиСообщенийОбОшибке", Comment = "", Synonym = "Адрес для отправки сообщений об ошибке")]
        [StringLength(100)]
        public string АдресДляОтправкиСообщенийОбОшибке {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НастройкиОбмена", Comment = "", Synonym = "Настройки обмена")]
        public List<УдалитьНастройкиВыполненияОбмена_НастройкиОбмена> УдалитьНастройкиВыполненияОбменаНастройкиОбмена {get;set;}
        [Description1C8(Name = "СообщенияНеЯвляющиесяОшибками", Comment = "", Synonym = "Сообщения не являющиеся ошибками")]
        public List<УдалитьНастройкиВыполненияОбмена_СообщенияНеЯвляющиесяОшибками> УдалитьНастройкиВыполненияОбменаСообщенияНеЯвляющиесяОшибками {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НастройкиОбмена", Comment = "", Synonym = "Настройки обмена")]
    [Table("UdalytNastroikyVypolnenyiaObmena_NastroikyObmena")]
    public class УдалитьНастройкиВыполненияОбмена_НастройкиОбмена
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НастройкаОбмена", Comment = "", Synonym = "Настройка обмена")]
        public Catalogs.УдалитьНастройкиОбменаДанными НастройкаОбмена {get; set;}
        [Description1C8(Name = "ВыполняемоеДействие", Comment = "", Synonym = "Выполняемое действие")]
        public Enums.УдалитьДействиеПриОбмене ВыполняемоеДействие {get; set;}
    }
    [Description1C8(Name = "СообщенияНеЯвляющиесяОшибками", Comment = "", Synonym = "Сообщения не являющиеся ошибками")]
    [Table("UdalytNastroikyVypolnenyiaObmena_SoobshchenyiaNeIavliaiushchyesiaOshybkamy")]
    public class УдалитьНастройкиВыполненияОбмена_СообщенияНеЯвляющиесяОшибками
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ТекстСообщения", Comment = "", Synonym = "Текст сообщения")]
        [StringLength(512)]
        public string ТекстСообщения {get; set;}
    }
}
