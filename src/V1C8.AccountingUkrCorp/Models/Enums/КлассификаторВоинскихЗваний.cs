using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КлассификаторВоинскихЗваний", Comment = "", Synonym = "Классификатор воинских званий")]
    public class КлассификаторВоинскихЗваний:EnumItem
    {
        public static readonly КлассификаторВоинскихЗваний Солдат = new КлассификаторВоинскихЗваний{Name= "Солдат",Synonim="Солдат",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Матрос = new КлассификаторВоинскихЗваний{Name= "Матрос",Synonim="Матрос",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийСолдат = new КлассификаторВоинскихЗваний{Name= "СтаршийСолдат",Synonim="Старший солдат",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийМатрос = new КлассификаторВоинскихЗваний{Name= "СтаршийМатрос",Synonim="Старший матрос",Comment=""};
        public static readonly КлассификаторВоинскихЗваний МладшийСержант = new КлассификаторВоинскихЗваний{Name= "МладшийСержант",Synonim="Младший сержант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Старшина2Статьи = new КлассификаторВоинскихЗваний{Name= "Старшина2Статьи",Synonim="Старшина2 статьи",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Сержант = new КлассификаторВоинскихЗваний{Name= "Сержант",Synonim="Сержант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Старшина1Статьи = new КлассификаторВоинскихЗваний{Name= "Старшина1Статьи",Synonim="Старшина1 статьи",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийСержант = new КлассификаторВоинскихЗваний{Name= "СтаршийСержант",Synonim="Старший сержант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГлавныйСтаршина = new КлассификаторВоинскихЗваний{Name= "ГлавныйСтаршина",Synonim="Главный старшина",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Старшина = new КлассификаторВоинскихЗваний{Name= "Старшина",Synonim="Старшина",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГлавныйКорабельныйСтаршина = new КлассификаторВоинскихЗваний{Name= "ГлавныйКорабельныйСтаршина",Synonim="Главный корабельный старшина",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Прапорщик = new КлассификаторВоинскихЗваний{Name= "Прапорщик",Synonim="Прапорщик",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Мичман = new КлассификаторВоинскихЗваний{Name= "Мичман",Synonim="Мичман",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийПрапорщик = new КлассификаторВоинскихЗваний{Name= "СтаршийПрапорщик",Synonim="Старший прапорщик",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийМичман = new КлассификаторВоинскихЗваний{Name= "СтаршийМичман",Synonim="Старший мичман",Comment=""};
        public static readonly КлассификаторВоинскихЗваний МладшийЛейтенант = new КлассификаторВоинскихЗваний{Name= "МладшийЛейтенант",Synonim="Младший лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Лейтенант = new КлассификаторВоинскихЗваний{Name= "Лейтенант",Synonim="Лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний СтаршийЛейтенант = new КлассификаторВоинскихЗваний{Name= "СтаршийЛейтенант",Synonim="Старший лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан = new КлассификаторВоинскихЗваний{Name= "Капитан",Synonim="Капитан",Comment=""};
        public static readonly КлассификаторВоинскихЗваний КапитанЛейтенант = new КлассификаторВоинскихЗваний{Name= "КапитанЛейтенант",Synonim="Капитан-лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Майор = new КлассификаторВоинскихЗваний{Name= "Майор",Synonim="Майор",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан3Ранга = new КлассификаторВоинскихЗваний{Name= "Капитан3Ранга",Synonim="Капитан 3 ранга",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Подполковник = new КлассификаторВоинскихЗваний{Name= "Подполковник",Synonim="Подполковник",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан2Ранга = new КлассификаторВоинскихЗваний{Name= "Капитан2Ранга",Synonim="Капитан 2 ранга",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Полковник = new КлассификаторВоинскихЗваний{Name= "Полковник",Synonim="Полковник",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Капитан1Ранга = new КлассификаторВоинскихЗваний{Name= "Капитан1Ранга",Synonim="Капитан 1 ранга",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералМайор = new КлассификаторВоинскихЗваний{Name= "ГенералМайор",Synonim="Генерал-майор",Comment=""};
        public static readonly КлассификаторВоинскихЗваний КонтрАдмирал = new КлассификаторВоинскихЗваний{Name= "КонтрАдмирал",Synonim="Контр-адмирал",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералЛейтенант = new КлассификаторВоинскихЗваний{Name= "ГенералЛейтенант",Synonim="Генерал-лейтенант",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ВицеАдмирал = new КлассификаторВоинскихЗваний{Name= "ВицеАдмирал",Synonim="Вице-адмирал",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералПолковник = new КлассификаторВоинскихЗваний{Name= "ГенералПолковник",Synonim="Генерал-полковник",Comment=""};
        public static readonly КлассификаторВоинскихЗваний Адмирал = new КлассификаторВоинскихЗваний{Name= "Адмирал",Synonim="Адмирал",Comment=""};
        public static readonly КлассификаторВоинскихЗваний ГенералАрмии = new КлассификаторВоинскихЗваний{Name= "ГенералАрмии",Synonim="Генерал армии Украины",Comment=""};
    }
}
