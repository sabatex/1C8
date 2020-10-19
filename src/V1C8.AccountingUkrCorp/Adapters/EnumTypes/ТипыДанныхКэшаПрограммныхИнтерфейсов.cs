using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыДанныхКэшаПрограммныхИнтерфейсов:EnumBase
    {
        public ТипыДанныхКэшаПрограммныхИнтерфейсов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОписаниеWebСервиса => GetProperty<EnumItem>("ОписаниеWebСервиса");
        public EnumItem ВерсииИнтерфейса => GetProperty<EnumItem>("ВерсииИнтерфейса");
    }
}
