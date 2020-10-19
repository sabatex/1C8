using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыФайловОбменаПоЗарплатномуПроекту:EnumBase
    {
        public ФорматыФайловОбменаПоЗарплатномуПроекту(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Версия1 => GetProperty<EnumItem>("Версия1");
        public EnumItem Версия3 => GetProperty<EnumItem>("Версия3");
        public EnumItem Версия32 => GetProperty<EnumItem>("Версия32");
        public EnumItem Версия33 => GetProperty<EnumItem>("Версия33");
        public EnumItem Версия34 => GetProperty<EnumItem>("Версия34");
    }
}
