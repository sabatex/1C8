using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыИспользованияАмортизации:V1C8COMObject
    {
        public ВидыИспользованияАмортизации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СтроительствоОбъектов => GetProperty<EnumItemBase>("СтроительствоОбъектов");
        public EnumItemBase ПриобретениеОсновныхСредств => GetProperty<EnumItemBase>("ПриобретениеОсновныхСредств");
        public EnumItemBase УлучшениеОсновныхСредств => GetProperty<EnumItemBase>("УлучшениеОсновныхСредств");
        public EnumItemBase ПриобретениеНематериальныхАктивов => GetProperty<EnumItemBase>("ПриобретениеНематериальныхАктивов");
        public EnumItemBase ДругиеКапитальныеРаботы => GetProperty<EnumItemBase>("ДругиеКапитальныеРаботы");
        public EnumItemBase ПогашениеПолученныхЗаймов => GetProperty<EnumItemBase>("ПогашениеПолученныхЗаймов");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
    }
}
