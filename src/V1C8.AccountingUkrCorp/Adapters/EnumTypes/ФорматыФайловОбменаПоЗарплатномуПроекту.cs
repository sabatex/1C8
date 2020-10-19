using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыФайловОбменаПоЗарплатномуПроекту:V1C8COMObject
    {
        public ФорматыФайловОбменаПоЗарплатномуПроекту(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Версия1 => GetProperty<EnumItemBase>("Версия1");
        public EnumItemBase Версия3 => GetProperty<EnumItemBase>("Версия3");
        public EnumItemBase Версия32 => GetProperty<EnumItemBase>("Версия32");
        public EnumItemBase Версия33 => GetProperty<EnumItemBase>("Версия33");
        public EnumItemBase Версия34 => GetProperty<EnumItemBase>("Версия34");
    }
}
