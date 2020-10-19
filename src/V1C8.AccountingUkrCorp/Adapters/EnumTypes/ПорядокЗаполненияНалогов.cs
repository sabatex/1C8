using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокЗаполненияНалогов:V1C8COMObject
    {
        public ПорядокЗаполненияНалогов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БезНалогов => GetProperty<EnumItemBase>("БезНалогов");
        public EnumItemBase НДФЛИВзносы => GetProperty<EnumItemBase>("НДФЛИВзносы");
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>("НДФЛ");
        public EnumItemBase Взносы => GetProperty<EnumItemBase>("Взносы");
    }
}
