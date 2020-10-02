using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КлассификаторВоинскихЗваний", Comment = "", Synonym = "Классификатор воинских званий")]
    public class КлассификаторВоинскихЗваний:EnumItem
    {
        public static readonly КлассификаторВоинскихЗваний Солдат = new КлассификаторВоинскихЗваний{Name= "Солдат",Synonym="Солдат",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Матрос = new КлассификаторВоинскихЗваний{Name= "Матрос",Synonym="Матрос",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийСолдат = new КлассификаторВоинскихЗваний{Name= "СтаршийСолдат",Synonym="Старший солдат",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийМатрос = new КлассификаторВоинскихЗваний{Name= "СтаршийМатрос",Synonym="Старший матрос",Comment=""};
        public static readonly КлассификаторВоинскихЗваний МладшийСержант = new КлассификаторВоинскихЗваний{Name= "МладшийСержант",Synonym="Младший сержант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Старшина2Статьи = new КлассификаторВоинскихЗваний{Name= "Старшина2Статьи",Synonym="Старшина2 статьи",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Сержант = new КлассификаторВоинскихЗваний{Name= "Сержант",Synonym="Сержант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Старшина1Статьи = new КлассификаторВоинскихЗваний{Name= "Старшина1Статьи",Synonym="Старшина1 статьи",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийСержант = new КлассификаторВоинскихЗваний{Name= "СтаршийСержант",Synonym="Старший сержант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГлавныйСтаршина = new КлассификаторВоинскихЗваний{Name= "ГлавныйСтаршина",Synonym="Главный старшина",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Старшина = new КлассификаторВоинскихЗваний{Name= "Старшина",Synonym="Старшина",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГлавныйКорабельныйСтаршина = new КлассификаторВоинскихЗваний{Name= "ГлавныйКорабельныйСтаршина",Synonym="Главный корабельный старшина",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Прапорщик = new КлассификаторВоинскихЗваний{Name= "Прапорщик",Synonym="Прапорщик",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Мичман = new КлассификаторВоинскихЗваний{Name= "Мичман",Synonym="Мичман",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийПрапорщик = new КлассификаторВоинскихЗваний{Name= "СтаршийПрапорщик",Synonym="Старший прапорщик",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийМичман = new КлассификаторВоинскихЗваний{Name= "СтаршийМичман",Synonym="Старший мичман",Comment=""};
        public static readonly КлассификаторВоинскихЗваний МладшийЛейтенант = new КлассификаторВоинскихЗваний{Name= "МладшийЛейтенант",Synonym="Младший лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Лейтенант = new КлассификаторВоинскихЗваний{Name= "Лейтенант",Synonym="Лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийЛейтенант = new КлассификаторВоинскихЗваний{Name= "СтаршийЛейтенант",Synonym="Старший лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан = new КлассификаторВоинскихЗваний{Name= "Капитан",Synonym="Капитан",Comment=""};
        public static readonly КлассификаторВоинскихЗваний КапитанЛейтенант = new КлассификаторВоинскихЗваний{Name= "КапитанЛейтенант",Synonym="Капитан-лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Майор = new КлассификаторВоинскихЗваний{Name= "Майор",Synonym="Майор",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан3Ранга = new КлассификаторВоинскихЗваний{Name= "Капитан3Ранга",Synonym="Капитан 3 ранга",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Подполковник = new КлассификаторВоинскихЗваний{Name= "Подполковник",Synonym="Подполковник",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан2Ранга = new КлассификаторВоинскихЗваний{Name= "Капитан2Ранга",Synonym="Капитан 2 ранга",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Полковник = new КлассификаторВоинскихЗваний{Name= "Полковник",Synonym="Полковник",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан1Ранга = new КлассификаторВоинскихЗваний{Name= "Капитан1Ранга",Synonym="Капитан 1 ранга",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералМайор = new КлассификаторВоинскихЗваний{Name= "ГенералМайор",Synonym="Генерал-майор",Comment=""};
        public static readonly КлассификаторВоинскихЗваний КонтрАдмирал = new КлассификаторВоинскихЗваний{Name= "КонтрАдмирал",Synonym="Контр-адмирал",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералЛейтенант = new КлассификаторВоинскихЗваний{Name= "ГенералЛейтенант",Synonym="Генерал-лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ВицеАдмирал = new КлассификаторВоинскихЗваний{Name= "ВицеАдмирал",Synonym="Вице-адмирал",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералПолковник = new КлассификаторВоинскихЗваний{Name= "ГенералПолковник",Synonym="Генерал-полковник",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Адмирал = new КлассификаторВоинскихЗваний{Name= "Адмирал",Synonym="Адмирал",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералАрмии = new КлассификаторВоинскихЗваний{Name= "ГенералАрмии",Synonym="Генерал армии Украины",Comment=""};
    }
}
