using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыИспользованияАмортизации:V1C8COMObject
    {
        public ВидыИспользованияАмортизации(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СтроительствоОбъектов => GetProperty<EnumItemBase>();
        public EnumItemBase ПриобретениеОсновныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase УлучшениеОсновныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase ПриобретениеНематериальныхАктивов => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеКапитальныеРаботы => GetProperty<EnumItemBase>();
        public EnumItemBase ПогашениеПолученныхЗаймов => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
    }
}
