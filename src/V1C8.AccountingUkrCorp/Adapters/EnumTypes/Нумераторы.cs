using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class Нумераторы:V1C8COMObject
    {
        public Нумераторы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПлатежноеПоручение => GetProperty<EnumItemBase>("ПлатежноеПоручение");
        public EnumItemBase РасходныйКассовыйОрдер => GetProperty<EnumItemBase>("РасходныйКассовыйОрдер");
        public EnumItemBase ПриходныйКассовыйОрдер => GetProperty<EnumItemBase>("ПриходныйКассовыйОрдер");
    }
}
