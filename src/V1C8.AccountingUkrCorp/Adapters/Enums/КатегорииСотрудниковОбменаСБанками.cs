using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииСотрудниковОбменаСБанками:V1C8COMObject
    {
        public КатегорииСотрудниковОбменаСБанками(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прочие => GetProperty<EnumItemBase>();
        public EnumItemBase Пенсионеры => GetProperty<EnumItemBase>();
        public EnumItemBase Студенты => GetProperty<EnumItemBase>();
    }
}
