using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыДанныхКэшаПрограммныхИнтерфейсов:V1C8COMObject
    {
        public ТипыДанныхКэшаПрограммныхИнтерфейсов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОписаниеWebСервиса => GetProperty<EnumItemBase>("ОписаниеWebСервиса");
        public EnumItemBase ВерсииИнтерфейса => GetProperty<EnumItemBase>("ВерсииИнтерфейса");
    }
}
