using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипДетализацииСтандартныхОтчетов:EnumBase
    {
        public ТипДетализацииСтандартныхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Элементы => GetProperty<EnumItem>("Элементы");
        public EnumItem Иерархия => GetProperty<EnumItem>("Иерархия");
        public EnumItem ТолькоИерархия => GetProperty<EnumItem>("ТолькоИерархия");
    }
}
