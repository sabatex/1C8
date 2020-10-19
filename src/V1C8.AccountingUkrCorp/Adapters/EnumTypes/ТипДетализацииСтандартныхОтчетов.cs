using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипДетализацииСтандартныхОтчетов:V1C8COMObject
    {
        public ТипДетализацииСтандартныхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Элементы => GetProperty<EnumItemBase>("Элементы");
        public EnumItemBase Иерархия => GetProperty<EnumItemBase>("Иерархия");
        public EnumItemBase ТолькоИерархия => GetProperty<EnumItemBase>("ТолькоИерархия");
    }
}
