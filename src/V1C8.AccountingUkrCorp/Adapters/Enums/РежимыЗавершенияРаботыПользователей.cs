using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РежимыЗавершенияРаботыПользователей:V1C8COMObject
    {
        public РежимыЗавершенияРаботыПользователей(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase РазрешитьРаботу => GetProperty<EnumItemBase>();
        public EnumItemBase ПредупредитьПользователейОЗавершенииРаботы => GetProperty<EnumItemBase>();
        public EnumItemBase ЗавершитьССохранениемДанныхПользователей => GetProperty<EnumItemBase>();
        public EnumItemBase ПрекратитьРаботуБезусловно => GetProperty<EnumItemBase>();
    }
}
