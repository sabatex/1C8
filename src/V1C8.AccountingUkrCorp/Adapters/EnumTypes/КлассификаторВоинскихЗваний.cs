using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КлассификаторВоинскихЗваний:V1C8COMObject
    {
        public КлассификаторВоинскихЗваний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Солдат => GetProperty<EnumItemBase>("Солдат");
        public EnumItemBase Матрос => GetProperty<EnumItemBase>("Матрос");
        public EnumItemBase СтаршийСолдат => GetProperty<EnumItemBase>("СтаршийСолдат");
        public EnumItemBase СтаршийМатрос => GetProperty<EnumItemBase>("СтаршийМатрос");
        public EnumItemBase МладшийСержант => GetProperty<EnumItemBase>("МладшийСержант");
        public EnumItemBase Старшина2Статьи => GetProperty<EnumItemBase>("Старшина2Статьи");
        public EnumItemBase Сержант => GetProperty<EnumItemBase>("Сержант");
        public EnumItemBase Старшина1Статьи => GetProperty<EnumItemBase>("Старшина1Статьи");
        public EnumItemBase СтаршийСержант => GetProperty<EnumItemBase>("СтаршийСержант");
        public EnumItemBase ГлавныйСтаршина => GetProperty<EnumItemBase>("ГлавныйСтаршина");
        public EnumItemBase Старшина => GetProperty<EnumItemBase>("Старшина");
        public EnumItemBase ГлавныйКорабельныйСтаршина => GetProperty<EnumItemBase>("ГлавныйКорабельныйСтаршина");
        public EnumItemBase Прапорщик => GetProperty<EnumItemBase>("Прапорщик");
        public EnumItemBase Мичман => GetProperty<EnumItemBase>("Мичман");
        public EnumItemBase СтаршийПрапорщик => GetProperty<EnumItemBase>("СтаршийПрапорщик");
        public EnumItemBase СтаршийМичман => GetProperty<EnumItemBase>("СтаршийМичман");
        public EnumItemBase МладшийЛейтенант => GetProperty<EnumItemBase>("МладшийЛейтенант");
        public EnumItemBase Лейтенант => GetProperty<EnumItemBase>("Лейтенант");
        public EnumItemBase СтаршийЛейтенант => GetProperty<EnumItemBase>("СтаршийЛейтенант");
        public EnumItemBase Капитан => GetProperty<EnumItemBase>("Капитан");
        public EnumItemBase КапитанЛейтенант => GetProperty<EnumItemBase>("КапитанЛейтенант");
        public EnumItemBase Майор => GetProperty<EnumItemBase>("Майор");
        public EnumItemBase Капитан3Ранга => GetProperty<EnumItemBase>("Капитан3Ранга");
        public EnumItemBase Подполковник => GetProperty<EnumItemBase>("Подполковник");
        public EnumItemBase Капитан2Ранга => GetProperty<EnumItemBase>("Капитан2Ранга");
        public EnumItemBase Полковник => GetProperty<EnumItemBase>("Полковник");
        public EnumItemBase Капитан1Ранга => GetProperty<EnumItemBase>("Капитан1Ранга");
        public EnumItemBase ГенералМайор => GetProperty<EnumItemBase>("ГенералМайор");
        public EnumItemBase КонтрАдмирал => GetProperty<EnumItemBase>("КонтрАдмирал");
        public EnumItemBase ГенералЛейтенант => GetProperty<EnumItemBase>("ГенералЛейтенант");
        public EnumItemBase ВицеАдмирал => GetProperty<EnumItemBase>("ВицеАдмирал");
        public EnumItemBase ГенералПолковник => GetProperty<EnumItemBase>("ГенералПолковник");
        public EnumItemBase Адмирал => GetProperty<EnumItemBase>("Адмирал");
        public EnumItemBase ГенералАрмии => GetProperty<EnumItemBase>("ГенералАрмии");
    }
}
