using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыЗавершенияРаботыПользователей:EnumBase
    {
        public РежимыЗавершенияРаботыПользователей(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem РазрешитьРаботу => GetProperty<EnumItem>("РазрешитьРаботу");
        public EnumItem ПредупредитьПользователейОЗавершенииРаботы => GetProperty<EnumItem>("ПредупредитьПользователейОЗавершенииРаботы");
        public EnumItem ЗавершитьССохранениемДанныхПользователей => GetProperty<EnumItem>("ЗавершитьССохранениемДанныхПользователей");
        public EnumItem ПрекратитьРаботуБезусловно => GetProperty<EnumItem>("ПрекратитьРаботуБезусловно");
    }
}
