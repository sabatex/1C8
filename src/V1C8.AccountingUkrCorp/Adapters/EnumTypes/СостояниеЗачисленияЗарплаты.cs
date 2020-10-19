using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостояниеЗачисленияЗарплаты:EnumBase
    {
        public СостояниеЗачисленияЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОжидаетПодтверждения => GetProperty<EnumItem>("ОжидаетПодтверждения");
        public EnumItem ГотовКВыгрузке => GetProperty<EnumItem>("ГотовКВыгрузке");
        public EnumItem ЗачисленоПолностью => GetProperty<EnumItem>("ЗачисленоПолностью");
        public EnumItem ЗачисленоСОшибками => GetProperty<EnumItem>("ЗачисленоСОшибками");
        public EnumItem НеЗачислено => GetProperty<EnumItem>("НеЗачислено");
    }
}
