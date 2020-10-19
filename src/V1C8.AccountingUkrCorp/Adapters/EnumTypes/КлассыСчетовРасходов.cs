using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КлассыСчетовРасходов:EnumBase
    {
        public КлассыСчетовРасходов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Класс8 => GetProperty<EnumItem>("Класс8");
        public EnumItem Класс9 => GetProperty<EnumItem>("Класс9");
        public EnumItem Класс8и9 => GetProperty<EnumItem>("Класс8и9");
    }
}
