using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КлассыСчетовРасходов:V1C8COMObject
    {
        public КлассыСчетовРасходов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Класс8 => GetProperty<EnumItemBase>("Класс8");
        public EnumItemBase Класс9 => GetProperty<EnumItemBase>("Класс9");
        public EnumItemBase Класс8и9 => GetProperty<EnumItemBase>("Класс8и9");
    }
}
