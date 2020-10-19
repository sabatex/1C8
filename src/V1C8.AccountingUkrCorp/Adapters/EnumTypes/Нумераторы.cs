using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class Нумераторы:EnumBase
    {
        public Нумераторы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПлатежноеПоручение => GetProperty<EnumItem>("ПлатежноеПоручение");
        public EnumItem РасходныйКассовыйОрдер => GetProperty<EnumItem>("РасходныйКассовыйОрдер");
        public EnumItem ПриходныйКассовыйОрдер => GetProperty<EnumItem>("ПриходныйКассовыйОрдер");
    }
}
