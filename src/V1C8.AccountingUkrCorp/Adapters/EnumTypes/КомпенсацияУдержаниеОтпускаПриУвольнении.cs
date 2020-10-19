using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КомпенсацияУдержаниеОтпускаПриУвольнении:EnumBase
    {
        public КомпенсацияУдержаниеОтпускаПриУвольнении(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеИспользовать => GetProperty<EnumItem>("НеИспользовать");
        public EnumItem КомпенсироватьНеИспользованные => GetProperty<EnumItem>("КомпенсироватьНеИспользованные");
        public EnumItem УдержатьЗаИспользованныеАвансом => GetProperty<EnumItem>("УдержатьЗаИспользованныеАвансом");
    }
}
