using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипДетализацииСтандартныхОтчетов:V1C8COMObject
    {
        public ТипДетализацииСтандартныхОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Элементы => GetProperty<EnumItemBase>();
        public EnumItemBase Иерархия => GetProperty<EnumItemBase>();
        public EnumItemBase ТолькоИерархия => GetProperty<EnumItemBase>();
    }
}
