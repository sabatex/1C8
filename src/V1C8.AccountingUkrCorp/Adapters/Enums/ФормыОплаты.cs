using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ФормыОплаты:V1C8COMObject
    {
        public ФормыОплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Наличная => GetProperty<EnumItemBase>();
        public EnumItemBase Безналичная => GetProperty<EnumItemBase>();
        public EnumItemBase ПлатежнаяКарта => GetProperty<EnumItemBase>();
        public EnumItemBase Взаимозачет => GetProperty<EnumItemBase>();
        public EnumItemBase БонусныеБаллы => GetProperty<EnumItemBase>();
        public EnumItemBase ПодарочныйСертификат => GetProperty<EnumItemBase>();
    }
}
