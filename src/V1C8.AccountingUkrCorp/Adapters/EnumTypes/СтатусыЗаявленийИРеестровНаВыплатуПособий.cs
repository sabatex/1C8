using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыЗаявленийИРеестровНаВыплатуПособий:V1C8COMObject
    {
        public СтатусыЗаявленийИРеестровНаВыплатуПособий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВРаботе => GetProperty<EnumItemBase>("ВРаботе");
        public EnumItemBase Подготовлен => GetProperty<EnumItemBase>("Подготовлен");
        public EnumItemBase ПереданВФСС => GetProperty<EnumItemBase>("ПереданВФСС");
        public EnumItemBase ПринятФСС => GetProperty<EnumItemBase>("ПринятФСС");
        public EnumItemBase НеПринятФСС => GetProperty<EnumItemBase>("НеПринятФСС");
        public EnumItemBase Аннулирован => GetProperty<EnumItemBase>("Аннулирован");
    }
}
