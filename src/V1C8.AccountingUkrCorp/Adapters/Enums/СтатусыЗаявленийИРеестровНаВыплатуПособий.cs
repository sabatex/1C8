using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтатусыЗаявленийИРеестровНаВыплатуПособий:V1C8COMObject
    {
        public СтатусыЗаявленийИРеестровНаВыплатуПособий(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВРаботе => GetProperty<EnumItemBase>();
        public EnumItemBase Подготовлен => GetProperty<EnumItemBase>();
        public EnumItemBase ПереданВФСС => GetProperty<EnumItemBase>();
        public EnumItemBase ПринятФСС => GetProperty<EnumItemBase>();
        public EnumItemBase НеПринятФСС => GetProperty<EnumItemBase>();
        public EnumItemBase Аннулирован => GetProperty<EnumItemBase>();
    }
}
