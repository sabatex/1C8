using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьВидыОбъектовКонтактнойИнформации:EnumBase
    {
        public УдалитьВидыОбъектовКонтактнойИнформации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Контрагенты => GetProperty<EnumItem>("Контрагенты");
        public EnumItem КонтактныеЛица => GetProperty<EnumItem>("КонтактныеЛица");
        public EnumItem ФизическиеЛица => GetProperty<EnumItem>("ФизическиеЛица");
        public EnumItem Организации => GetProperty<EnumItem>("Организации");
        public EnumItem Пользователи => GetProperty<EnumItem>("Пользователи");
    }
}
