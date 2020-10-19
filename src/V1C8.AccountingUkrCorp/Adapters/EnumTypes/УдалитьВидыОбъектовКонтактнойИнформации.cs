using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьВидыОбъектовКонтактнойИнформации:V1C8COMObject
    {
        public УдалитьВидыОбъектовКонтактнойИнформации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Контрагенты => GetProperty<EnumItemBase>("Контрагенты");
        public EnumItemBase КонтактныеЛица => GetProperty<EnumItemBase>("КонтактныеЛица");
        public EnumItemBase ФизическиеЛица => GetProperty<EnumItemBase>("ФизическиеЛица");
        public EnumItemBase Организации => GetProperty<EnumItemBase>("Организации");
        public EnumItemBase Пользователи => GetProperty<EnumItemBase>("Пользователи");
    }
}
