using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСотрудниковОбменаСБанками:V1C8COMObject
    {
        public КатегорииСотрудниковОбменаСБанками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прочие => GetProperty<EnumItemBase>("Прочие");
        public EnumItemBase Пенсионеры => GetProperty<EnumItemBase>("Пенсионеры");
        public EnumItemBase Студенты => GetProperty<EnumItemBase>("Студенты");
    }
}
