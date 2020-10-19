using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыРаботыФормыСотрудника:V1C8COMObject
    {
        public РежимыРаботыФормыСотрудника(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Сотрудник => GetProperty<EnumItemBase>("Сотрудник");
        public EnumItemBase СотрудникОформленныйПоДоговоруГПХ => GetProperty<EnumItemBase>("СотрудникОформленныйПоДоговоруГПХ");
        public EnumItemBase СотрудникОформленныйПоТрудовомуДоговору => GetProperty<EnumItemBase>("СотрудникОформленныйПоТрудовомуДоговору");
        public EnumItemBase СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ => GetProperty<EnumItemBase>("СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ");
        public EnumItemBase ФизическоеЛицо => GetProperty<EnumItemBase>("ФизическоеЛицо");
    }
}
