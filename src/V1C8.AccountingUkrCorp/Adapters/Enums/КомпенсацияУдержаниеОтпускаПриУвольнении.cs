using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КомпенсацияУдержаниеОтпускаПриУвольнении:V1C8COMObject
    {
        public КомпенсацияУдержаниеОтпускаПриУвольнении(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеИспользовать => GetProperty<EnumItemBase>();
        public EnumItemBase КомпенсироватьНеИспользованные => GetProperty<EnumItemBase>();
        public EnumItemBase УдержатьЗаИспользованныеАвансом => GetProperty<EnumItemBase>();
    }
}
