using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаОтпуска:V1C8COMObject
    {
        public СпособыРасчетаОтпуска(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВКалендарныхДнях => GetProperty<EnumItemBase>("ВКалендарныхДнях");
        public EnumItemBase ВРабочихДнях => GetProperty<EnumItemBase>("ВРабочихДнях");
        public EnumItemBase ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора => GetProperty<EnumItemBase>("ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора");
        public EnumItemBase ВКалендарныхДняхСПраздниками => GetProperty<EnumItemBase>("ВКалендарныхДняхСПраздниками");
    }
}
