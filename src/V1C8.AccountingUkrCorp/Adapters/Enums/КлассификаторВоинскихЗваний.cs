using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КлассификаторВоинскихЗваний:V1C8COMObject
    {
        public КлассификаторВоинскихЗваний(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Солдат => GetProperty<EnumItemBase>();
        public EnumItemBase Матрос => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршийСолдат => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршийМатрос => GetProperty<EnumItemBase>();
        public EnumItemBase МладшийСержант => GetProperty<EnumItemBase>();
        public EnumItemBase Старшина2Статьи => GetProperty<EnumItemBase>();
        public EnumItemBase Сержант => GetProperty<EnumItemBase>();
        public EnumItemBase Старшина1Статьи => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршийСержант => GetProperty<EnumItemBase>();
        public EnumItemBase ГлавныйСтаршина => GetProperty<EnumItemBase>();
        public EnumItemBase Старшина => GetProperty<EnumItemBase>();
        public EnumItemBase ГлавныйКорабельныйСтаршина => GetProperty<EnumItemBase>();
        public EnumItemBase Прапорщик => GetProperty<EnumItemBase>();
        public EnumItemBase Мичман => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршийПрапорщик => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршийМичман => GetProperty<EnumItemBase>();
        public EnumItemBase МладшийЛейтенант => GetProperty<EnumItemBase>();
        public EnumItemBase Лейтенант => GetProperty<EnumItemBase>();
        public EnumItemBase СтаршийЛейтенант => GetProperty<EnumItemBase>();
        public EnumItemBase Капитан => GetProperty<EnumItemBase>();
        public EnumItemBase КапитанЛейтенант => GetProperty<EnumItemBase>();
        public EnumItemBase Майор => GetProperty<EnumItemBase>();
        public EnumItemBase Капитан3Ранга => GetProperty<EnumItemBase>();
        public EnumItemBase Подполковник => GetProperty<EnumItemBase>();
        public EnumItemBase Капитан2Ранга => GetProperty<EnumItemBase>();
        public EnumItemBase Полковник => GetProperty<EnumItemBase>();
        public EnumItemBase Капитан1Ранга => GetProperty<EnumItemBase>();
        public EnumItemBase ГенералМайор => GetProperty<EnumItemBase>();
        public EnumItemBase КонтрАдмирал => GetProperty<EnumItemBase>();
        public EnumItemBase ГенералЛейтенант => GetProperty<EnumItemBase>();
        public EnumItemBase ВицеАдмирал => GetProperty<EnumItemBase>();
        public EnumItemBase ГенералПолковник => GetProperty<EnumItemBase>();
        public EnumItemBase Адмирал => GetProperty<EnumItemBase>();
        public EnumItemBase ГенералАрмии => GetProperty<EnumItemBase>();
    }
}
