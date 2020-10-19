using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыПолейРегистра:V1C8COMObject
    {
        public ТипыПолейРегистра(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Измерение => GetProperty<EnumItemBase>();
        public EnumItemBase Ресурс => GetProperty<EnumItemBase>();
        public EnumItemBase Реквизит => GetProperty<EnumItemBase>();
    }
}
