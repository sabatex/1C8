using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РежимыРаботыФормыСотрудника:V1C8COMObject
    {
        public РежимыРаботыФормыСотрудника(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Сотрудник => GetProperty<EnumItemBase>();
        public EnumItemBase СотрудникОформленныйПоДоговоруГПХ => GetProperty<EnumItemBase>();
        public EnumItemBase СотрудникОформленныйПоТрудовомуДоговору => GetProperty<EnumItemBase>();
        public EnumItemBase СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ => GetProperty<EnumItemBase>();
        public EnumItemBase ФизическоеЛицо => GetProperty<EnumItemBase>();
    }
}
