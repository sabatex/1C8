using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыЗаполненияГрафикаРаботы:EnumBase
    {
        public СпособыЗаполненияГрафикаРаботы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоНеделям => GetProperty<EnumItem>("ПоНеделям");
        public EnumItem ПоЦикламПроизвольнойДлины => GetProperty<EnumItem>("ПоЦикламПроизвольнойДлины");
    }
}
