using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОтветственныеЛицаОрганизаций:V1C8COMObject
    {
        public ОтветственныеЛицаОрганизаций(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Руководитель => GetProperty<EnumItemBase>("Руководитель");
        public EnumItemBase ГлавныйБухгалтер => GetProperty<EnumItemBase>("ГлавныйБухгалтер");
        public EnumItemBase РуководительКадровойСлужбы => GetProperty<EnumItemBase>("РуководительКадровойСлужбы");
        public EnumItemBase Кассир => GetProperty<EnumItemBase>("Кассир");
        public EnumItemBase ОтветственныйЗаБухгалтерскиеРегистры => GetProperty<EnumItemBase>("ОтветственныйЗаБухгалтерскиеРегистры");
    }
}
