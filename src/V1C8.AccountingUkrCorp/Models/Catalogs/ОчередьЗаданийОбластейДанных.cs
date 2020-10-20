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
    [Table("OcheredZadanyiOblasteiDannykh")]
    [Description1C8(Name = "ОчередьЗаданийОбластейДанных", Comment = "", Synonym = "Очередь заданий областей данных")]
    public class ОчередьЗаданийОбластейДанных
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
    [Description1C8(Name = "Использование", Comment = "", Synonym = "Использование")]
    public bool Использование {get; set;}
    [Description1C8(Name = "ЗапланированныйМоментЗапуска", Comment = "", Synonym = "Запланированный момент запуска")]
    public DateTime ЗапланированныйМоментЗапуска {get; set;}
    [Description1C8(Name = "СостояниеЗадания", Comment = "", Synonym = "Состояние задания")]
    public Enums.СостоянияЗаданий СостояниеЗадания {get; set;}
    [Description1C8(Name = "ИсполняющееФоновоеЗадание", Comment = "", Synonym = "Исполняющее фоновое задание")]
    public Guid ИсполняющееФоновоеЗадание {get; set;}
    [Description1C8(Name = "ЭксклюзивноеВыполнение", Comment = "", Synonym = "Эксклюзивное выполнение")]
    public bool ЭксклюзивноеВыполнение {get; set;}
    [Description1C8(Name = "Шаблон", Comment = "", Synonym = "Шаблон")]
    public Catalogs.ШаблоныЗаданийОчереди Шаблон {get; set;}
    [Description1C8(Name = "НомерПопытки", Comment = "", Synonym = "Номер попытки")]
    // Format 3.0
    public long НомерПопытки {get; set;}
    [Description1C8(Name = "ИмяМетода", Comment = "", Synonym = "Имя метода")]
    [StringLength(255)]
    public string ИмяМетода {get; set;}
    [Description1C8(Name = "Параметры", Comment = "", Synonym = "Параметры")]
    // Сховище значень
    public byte[] Параметры {get; set;}
    [Description1C8(Name = "ДатаНачалаПоследнегоЗапуска", Comment = "", Synonym = "Дата начала последнего запуска")]
    public DateTime ДатаНачалаПоследнегоЗапуска {get; set;}
    [Description1C8(Name = "ДатаЗавершенияПоследнегоЗапуска", Comment = "", Synonym = "Дата завершения последнего запуска")]
    public DateTime ДатаЗавершенияПоследнегоЗапуска {get; set;}
    [Description1C8(Name = "Ключ", Comment = "", Synonym = "Ключ")]
    [StringLength(128)]
    public string Ключ {get; set;}
    [Description1C8(Name = "ИнтервалПовтораПриАварийномЗавершении", Comment = "", Synonym = "Интервал повтора при аварийном завершении")]
    // Format 10.0
    public long ИнтервалПовтораПриАварийномЗавершении {get; set;}
    [Description1C8(Name = "Расписание", Comment = "", Synonym = "Расписание")]
    // Сховище значень
    public byte[] Расписание {get; set;}
    [Description1C8(Name = "КоличествоПовторовПриАварийномЗавершении", Comment = "", Synonym = "Количество повторов при аварийном завершении")]
    // Format 10.0
    public long КоличествоПовторовПриАварийномЗавершении {get; set;}
    #endregion реквізити
    }
}
