using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыДанныхКэшаПрограммныхИнтерфейсов:V1C8COMObject
    {
        public ТипыДанныхКэшаПрограммныхИнтерфейсов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОписаниеWebСервиса => GetProperty<EnumItemBase>();
        public EnumItemBase ВерсииИнтерфейса => GetProperty<EnumItemBase>();
    }
}
