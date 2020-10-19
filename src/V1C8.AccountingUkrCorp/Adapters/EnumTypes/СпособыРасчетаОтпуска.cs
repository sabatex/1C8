using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаОтпуска:EnumBase
    {
        public СпособыРасчетаОтпуска(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВКалендарныхДнях => GetProperty<EnumItem>("ВКалендарныхДнях");
        public EnumItem ВРабочихДнях => GetProperty<EnumItem>("ВРабочихДнях");
        public EnumItem ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора => GetProperty<EnumItem>("ВКалендарныхИлиРабочихДняхВЗависимостиОтТрудовогоДоговора");
        public EnumItem ВКалендарныхДняхСПраздниками => GetProperty<EnumItem>("ВКалендарныхДняхСПраздниками");
    }
}
