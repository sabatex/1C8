using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ОтветственныеЛицаОрганизаций:V1C8COMObject
    {
        public ОтветственныеЛицаОрганизаций(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Руководитель => GetProperty<EnumItemBase>();
        public EnumItemBase ГлавныйБухгалтер => GetProperty<EnumItemBase>();
        public EnumItemBase РуководительКадровойСлужбы => GetProperty<EnumItemBase>();
        public EnumItemBase Кассир => GetProperty<EnumItemBase>();
        public EnumItemBase ОтветственныйЗаБухгалтерскиеРегистры => GetProperty<EnumItemBase>();
    }
}
