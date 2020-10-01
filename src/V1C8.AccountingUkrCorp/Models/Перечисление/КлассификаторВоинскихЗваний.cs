using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КлассификаторВоинскихЗваний", Comment = "", Synonym = "Классификатор воинских званий")]
    public enum КлассификаторВоинскихЗваний
    {
        [Description1C8(Name = "Солдат", Comment = "", Synonym = "Солдат")]
        Солдат,
        [Description1C8(Name = "Матрос", Comment = "", Synonym = "Матрос")]
        Матрос,
        [Description1C8(Name = "СтаршийСолдат", Comment = "", Synonym = "Старший солдат")]
        СтаршийСолдат,
        [Description1C8(Name = "СтаршийМатрос", Comment = "", Synonym = "Старший матрос")]
        СтаршийМатрос,
        [Description1C8(Name = "МладшийСержант", Comment = "", Synonym = "Младший сержант")]
        МладшийСержант,
        [Description1C8(Name = "Старшина2Статьи", Comment = "", Synonym = "Старшина2 статьи")]
        Старшина2Статьи,
        [Description1C8(Name = "Сержант", Comment = "", Synonym = "Сержант")]
        Сержант,
        [Description1C8(Name = "Старшина1Статьи", Comment = "", Synonym = "Старшина1 статьи")]
        Старшина1Статьи,
        [Description1C8(Name = "СтаршийСержант", Comment = "", Synonym = "Старший сержант")]
        СтаршийСержант,
        [Description1C8(Name = "ГлавныйСтаршина", Comment = "", Synonym = "Главный старшина")]
        ГлавныйСтаршина,
        [Description1C8(Name = "Старшина", Comment = "", Synonym = "Старшина")]
        Старшина,
        [Description1C8(Name = "ГлавныйКорабельныйСтаршина", Comment = "", Synonym = "Главный корабельный старшина")]
        ГлавныйКорабельныйСтаршина,
        [Description1C8(Name = "Прапорщик", Comment = "", Synonym = "Прапорщик")]
        Прапорщик,
        [Description1C8(Name = "Мичман", Comment = "", Synonym = "Мичман")]
        Мичман,
        [Description1C8(Name = "СтаршийПрапорщик", Comment = "", Synonym = "Старший прапорщик")]
        СтаршийПрапорщик,
        [Description1C8(Name = "СтаршийМичман", Comment = "", Synonym = "Старший мичман")]
        СтаршийМичман,
        [Description1C8(Name = "МладшийЛейтенант", Comment = "", Synonym = "Младший лейтенант")]
        МладшийЛейтенант,
        [Description1C8(Name = "Лейтенант", Comment = "", Synonym = "Лейтенант")]
        Лейтенант,
        [Description1C8(Name = "СтаршийЛейтенант", Comment = "", Synonym = "Старший лейтенант")]
        СтаршийЛейтенант,
        [Description1C8(Name = "Капитан", Comment = "", Synonym = "Капитан")]
        Капитан,
        [Description1C8(Name = "КапитанЛейтенант", Comment = "", Synonym = "Капитан-лейтенант")]
        КапитанЛейтенант,
        [Description1C8(Name = "Майор", Comment = "", Synonym = "Майор")]
        Майор,
        [Description1C8(Name = "Капитан3Ранга", Comment = "", Synonym = "Капитан 3 ранга")]
        Капитан3Ранга,
        [Description1C8(Name = "Подполковник", Comment = "", Synonym = "Подполковник")]
        Подполковник,
        [Description1C8(Name = "Капитан2Ранга", Comment = "", Synonym = "Капитан 2 ранга")]
        Капитан2Ранга,
        [Description1C8(Name = "Полковник", Comment = "", Synonym = "Полковник")]
        Полковник,
        [Description1C8(Name = "Капитан1Ранга", Comment = "", Synonym = "Капитан 1 ранга")]
        Капитан1Ранга,
        [Description1C8(Name = "ГенералМайор", Comment = "", Synonym = "Генерал-майор")]
        ГенералМайор,
        [Description1C8(Name = "КонтрАдмирал", Comment = "", Synonym = "Контр-адмирал")]
        КонтрАдмирал,
        [Description1C8(Name = "ГенералЛейтенант", Comment = "", Synonym = "Генерал-лейтенант")]
        ГенералЛейтенант,
        [Description1C8(Name = "ВицеАдмирал", Comment = "", Synonym = "Вице-адмирал")]
        ВицеАдмирал,
        [Description1C8(Name = "ГенералПолковник", Comment = "", Synonym = "Генерал-полковник")]
        ГенералПолковник,
        [Description1C8(Name = "Адмирал", Comment = "", Synonym = "Адмирал")]
        Адмирал,
        [Description1C8(Name = "ГенералАрмии", Comment = "", Synonym = "Генерал армии Украины")]
        ГенералАрмии
    }
}
