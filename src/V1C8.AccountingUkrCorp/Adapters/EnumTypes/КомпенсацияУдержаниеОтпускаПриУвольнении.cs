using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КомпенсацияУдержаниеОтпускаПриУвольнении:V1C8COMObject
    {
        public КомпенсацияУдержаниеОтпускаПриУвольнении(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеИспользовать => GetProperty<EnumItemBase>("НеИспользовать");
        public EnumItemBase КомпенсироватьНеИспользованные => GetProperty<EnumItemBase>("КомпенсироватьНеИспользованные");
        public EnumItemBase УдержатьЗаИспользованныеАвансом => GetProperty<EnumItemBase>("УдержатьЗаИспользованныеАвансом");
    }
}
