using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыЗаполненияГрафикаРаботы:V1C8COMObject
    {
        public СпособыЗаполненияГрафикаРаботы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоНеделям => GetProperty<EnumItemBase>("ПоНеделям");
        public EnumItemBase ПоЦикламПроизвольнойДлины => GetProperty<EnumItemBase>("ПоЦикламПроизвольнойДлины");
    }
}
