using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьВидыОбъектовКонтактнойИнформации:V1C8COMObject
    {
        public УдалитьВидыОбъектовКонтактнойИнформации(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Контрагенты => GetProperty<EnumItemBase>();
        public EnumItemBase КонтактныеЛица => GetProperty<EnumItemBase>();
        public EnumItemBase ФизическиеЛица => GetProperty<EnumItemBase>();
        public EnumItemBase Организации => GetProperty<EnumItemBase>();
        public EnumItemBase Пользователи => GetProperty<EnumItemBase>();
    }
}
