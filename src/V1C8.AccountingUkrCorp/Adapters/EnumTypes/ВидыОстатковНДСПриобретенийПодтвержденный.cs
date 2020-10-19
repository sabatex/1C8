using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОстатковНДСПриобретенийПодтвержденный:V1C8COMObject
    {
        public ВидыОстатковНДСПриобретенийПодтвержденный(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеправильноЗарегистрированы => GetProperty<EnumItemBase>("НеправильноЗарегистрированы");
        public EnumItemBase ПолученыИзлишне => GetProperty<EnumItemBase>("ПолученыИзлишне");
        public EnumItemBase ПолученыЗаранее => GetProperty<EnumItemBase>("ПолученыЗаранее");
    }
}
