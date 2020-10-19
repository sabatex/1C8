using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФормыОплаты:V1C8COMObject
    {
        public ФормыОплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Наличная => GetProperty<EnumItemBase>("Наличная");
        public EnumItemBase Безналичная => GetProperty<EnumItemBase>("Безналичная");
        public EnumItemBase ПлатежнаяКарта => GetProperty<EnumItemBase>("ПлатежнаяКарта");
        public EnumItemBase Взаимозачет => GetProperty<EnumItemBase>("Взаимозачет");
        public EnumItemBase БонусныеБаллы => GetProperty<EnumItemBase>("БонусныеБаллы");
        public EnumItemBase ПодарочныйСертификат => GetProperty<EnumItemBase>("ПодарочныйСертификат");
    }
}
