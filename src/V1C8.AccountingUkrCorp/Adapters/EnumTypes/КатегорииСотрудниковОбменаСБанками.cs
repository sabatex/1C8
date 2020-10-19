using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСотрудниковОбменаСБанками:EnumBase
    {
        public КатегорииСотрудниковОбменаСБанками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Прочие => GetProperty<EnumItem>("Прочие");
        public EnumItem Пенсионеры => GetProperty<EnumItem>("Пенсионеры");
        public EnumItem Студенты => GetProperty<EnumItem>("Студенты");
    }
}
