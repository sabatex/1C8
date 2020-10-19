using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФормыОплаты:EnumBase
    {
        public ФормыОплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Наличная => GetProperty<EnumItem>("Наличная");
        public EnumItem Безналичная => GetProperty<EnumItem>("Безналичная");
        public EnumItem ПлатежнаяКарта => GetProperty<EnumItem>("ПлатежнаяКарта");
        public EnumItem Взаимозачет => GetProperty<EnumItem>("Взаимозачет");
        public EnumItem БонусныеБаллы => GetProperty<EnumItem>("БонусныеБаллы");
        public EnumItem ПодарочныйСертификат => GetProperty<EnumItem>("ПодарочныйСертификат");
    }
}
