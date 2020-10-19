using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаОтпуска:V1C8COMObject
    {
        public СпособыРасчетаОтпуска(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВКалендарныхДнях => GetProperty<EnumItemBase>();
        public EnumItemBase ВРабочихДнях => GetProperty<EnumItemBase>();
        public EnumItemBase ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора => GetProperty<EnumItemBase>();
        public EnumItemBase ВКалендарныхДняхСПраздниками => GetProperty<EnumItemBase>();
    }
}
