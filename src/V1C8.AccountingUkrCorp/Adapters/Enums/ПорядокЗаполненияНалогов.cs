using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядокЗаполненияНалогов:V1C8COMObject
    {
        public ПорядокЗаполненияНалогов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БезНалогов => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛИВзносы => GetProperty<EnumItemBase>();
        public EnumItemBase НДФЛ => GetProperty<EnumItemBase>();
        public EnumItemBase Взносы => GetProperty<EnumItemBase>();
    }
}
