using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОтветственныеЛицаОрганизаций:EnumBase
    {
        public ОтветственныеЛицаОрганизаций(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Руководитель => GetProperty<EnumItem>("Руководитель");
        public EnumItem ГлавныйБухгалтер => GetProperty<EnumItem>("ГлавныйБухгалтер");
        public EnumItem РуководительКадровойСлужбы => GetProperty<EnumItem>("РуководительКадровойСлужбы");
        public EnumItem Кассир => GetProperty<EnumItem>("Кассир");
        public EnumItem ОтветственныйЗаБухгалтерскиеРегистры => GetProperty<EnumItem>("ОтветственныйЗаБухгалтерскиеРегистры");
    }
}
