using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОстатковНДСПриобретенийПодтвержденный:V1C8COMObject
    {
        public ВидыОстатковНДСПриобретенийПодтвержденный(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеправильноЗарегистрированы => GetProperty<EnumItemBase>();
        public EnumItemBase ПолученыИзлишне => GetProperty<EnumItemBase>();
        public EnumItemBase ПолученыЗаранее => GetProperty<EnumItemBase>();
    }
}
