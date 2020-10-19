using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыИспользованияАмортизации:EnumBase
    {
        public ВидыИспользованияАмортизации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СтроительствоОбъектов => GetProperty<EnumItem>("СтроительствоОбъектов");
        public EnumItem ПриобретениеОсновныхСредств => GetProperty<EnumItem>("ПриобретениеОсновныхСредств");
        public EnumItem УлучшениеОсновныхСредств => GetProperty<EnumItem>("УлучшениеОсновныхСредств");
        public EnumItem ПриобретениеНематериальныхАктивов => GetProperty<EnumItem>("ПриобретениеНематериальныхАктивов");
        public EnumItem ДругиеКапитальныеРаботы => GetProperty<EnumItem>("ДругиеКапитальныеРаботы");
        public EnumItem ПогашениеПолученныхЗаймов => GetProperty<EnumItem>("ПогашениеПолученныхЗаймов");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
    }
}
