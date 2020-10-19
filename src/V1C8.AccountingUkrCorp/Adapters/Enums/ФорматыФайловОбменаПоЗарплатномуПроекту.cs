using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ФорматыФайловОбменаПоЗарплатномуПроекту:V1C8COMObject
    {
        public ФорматыФайловОбменаПоЗарплатномуПроекту(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Версия1 => GetProperty<EnumItemBase>();
        public EnumItemBase Версия3 => GetProperty<EnumItemBase>();
        public EnumItemBase Версия32 => GetProperty<EnumItemBase>();
        public EnumItemBase Версия33 => GetProperty<EnumItemBase>();
        public EnumItemBase Версия34 => GetProperty<EnumItemBase>();
    }
}
