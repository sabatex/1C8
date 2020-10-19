using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КлассификаторВоинскихЗваний:EnumBase
    {
        public КлассификаторВоинскихЗваний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Солдат => GetProperty<EnumItem>("Солдат");
        public EnumItem Матрос => GetProperty<EnumItem>("Матрос");
        public EnumItem СтаршийСолдат => GetProperty<EnumItem>("СтаршийСолдат");
        public EnumItem СтаршийМатрос => GetProperty<EnumItem>("СтаршийМатрос");
        public EnumItem МладшийСержант => GetProperty<EnumItem>("МладшийСержант");
        public EnumItem Старшина2Статьи => GetProperty<EnumItem>("Старшина2Статьи");
        public EnumItem Сержант => GetProperty<EnumItem>("Сержант");
        public EnumItem Старшина1Статьи => GetProperty<EnumItem>("Старшина1Статьи");
        public EnumItem СтаршийСержант => GetProperty<EnumItem>("СтаршийСержант");
        public EnumItem ГлавныйСтаршина => GetProperty<EnumItem>("ГлавныйСтаршина");
        public EnumItem Старшина => GetProperty<EnumItem>("Старшина");
        public EnumItem ГлавныйКорабельныйСтаршина => GetProperty<EnumItem>("ГлавныйКорабельныйСтаршина");
        public EnumItem Прапорщик => GetProperty<EnumItem>("Прапорщик");
        public EnumItem Мичман => GetProperty<EnumItem>("Мичман");
        public EnumItem СтаршийПрапорщик => GetProperty<EnumItem>("СтаршийПрапорщик");
        public EnumItem СтаршийМичман => GetProperty<EnumItem>("СтаршийМичман");
        public EnumItem МладшийЛейтенант => GetProperty<EnumItem>("МладшийЛейтенант");
        public EnumItem Лейтенант => GetProperty<EnumItem>("Лейтенант");
        public EnumItem СтаршийЛейтенант => GetProperty<EnumItem>("СтаршийЛейтенант");
        public EnumItem Капитан => GetProperty<EnumItem>("Капитан");
        public EnumItem КапитанЛейтенант => GetProperty<EnumItem>("КапитанЛейтенант");
        public EnumItem Майор => GetProperty<EnumItem>("Майор");
        public EnumItem Капитан3Ранга => GetProperty<EnumItem>("Капитан3Ранга");
        public EnumItem Подполковник => GetProperty<EnumItem>("Подполковник");
        public EnumItem Капитан2Ранга => GetProperty<EnumItem>("Капитан2Ранга");
        public EnumItem Полковник => GetProperty<EnumItem>("Полковник");
        public EnumItem Капитан1Ранга => GetProperty<EnumItem>("Капитан1Ранга");
        public EnumItem ГенералМайор => GetProperty<EnumItem>("ГенералМайор");
        public EnumItem КонтрАдмирал => GetProperty<EnumItem>("КонтрАдмирал");
        public EnumItem ГенералЛейтенант => GetProperty<EnumItem>("ГенералЛейтенант");
        public EnumItem ВицеАдмирал => GetProperty<EnumItem>("ВицеАдмирал");
        public EnumItem ГенералПолковник => GetProperty<EnumItem>("ГенералПолковник");
        public EnumItem Адмирал => GetProperty<EnumItem>("Адмирал");
        public EnumItem ГенералАрмии => GetProperty<EnumItem>("ГенералАрмии");
    }
}
