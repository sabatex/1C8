using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыРаботыФормыСотрудника:EnumBase
    {
        public РежимыРаботыФормыСотрудника(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Сотрудник => GetProperty<EnumItem>("Сотрудник");
        public EnumItem СотрудникОформленныйПоДоговоруГПХ => GetProperty<EnumItem>("СотрудникОформленныйПоДоговоруГПХ");
        public EnumItem СотрудникОформленныйПоТрудовомуДоговору => GetProperty<EnumItem>("СотрудникОформленныйПоТрудовомуДоговору");
        public EnumItem СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ => GetProperty<EnumItem>("СотрудникОформленныйПоТрудовомуДоговоруИДоговоруГПХ");
        public EnumItem ФизическоеЛицо => GetProperty<EnumItem>("ФизическоеЛицо");
    }
}
