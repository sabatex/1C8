using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыЗавершенияРаботыПользователей:V1C8COMObject
    {
        public РежимыЗавершенияРаботыПользователей(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РазрешитьРаботу => GetProperty<EnumItemBase>("РазрешитьРаботу");
        public EnumItemBase ПредупредитьПользователейОЗавершенииРаботы => GetProperty<EnumItemBase>("ПредупредитьПользователейОЗавершенииРаботы");
        public EnumItemBase ЗавершитьССохранениемДанныхПользователей => GetProperty<EnumItemBase>("ЗавершитьССохранениемДанныхПользователей");
        public EnumItemBase ПрекратитьРаботуБезусловно => GetProperty<EnumItemBase>("ПрекратитьРаботуБезусловно");
    }
}
