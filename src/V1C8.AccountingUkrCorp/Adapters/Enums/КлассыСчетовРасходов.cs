using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КлассыСчетовРасходов:V1C8COMObject
    {
        public КлассыСчетовРасходов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Класс8 => GetProperty<EnumItemBase>();
        public EnumItemBase Класс9 => GetProperty<EnumItemBase>();
        public EnumItemBase Класс8и9 => GetProperty<EnumItemBase>();
    }
}
