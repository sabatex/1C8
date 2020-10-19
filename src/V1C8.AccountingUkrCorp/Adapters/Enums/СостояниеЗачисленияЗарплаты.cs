using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостояниеЗачисленияЗарплаты:V1C8COMObject
    {
        public СостояниеЗачисленияЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОжидаетПодтверждения => GetProperty<EnumItemBase>();
        public EnumItemBase ГотовКВыгрузке => GetProperty<EnumItemBase>();
        public EnumItemBase ЗачисленоПолностью => GetProperty<EnumItemBase>();
        public EnumItemBase ЗачисленоСОшибками => GetProperty<EnumItemBase>();
        public EnumItemBase НеЗачислено => GetProperty<EnumItemBase>();
    }
}
