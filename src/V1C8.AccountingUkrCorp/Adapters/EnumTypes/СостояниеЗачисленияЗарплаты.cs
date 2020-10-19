using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостояниеЗачисленияЗарплаты:V1C8COMObject
    {
        public СостояниеЗачисленияЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОжидаетПодтверждения => GetProperty<EnumItemBase>("ОжидаетПодтверждения");
        public EnumItemBase ГотовКВыгрузке => GetProperty<EnumItemBase>("ГотовКВыгрузке");
        public EnumItemBase ЗачисленоПолностью => GetProperty<EnumItemBase>("ЗачисленоПолностью");
        public EnumItemBase ЗачисленоСОшибками => GetProperty<EnumItemBase>("ЗачисленоСОшибками");
        public EnumItemBase НеЗачислено => GetProperty<EnumItemBase>("НеЗачислено");
    }
}
