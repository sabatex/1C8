using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыЗаявленийИРеестровНаВыплатуПособий:EnumBase
    {
        public СтатусыЗаявленийИРеестровНаВыплатуПособий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВРаботе => GetProperty<EnumItem>("ВРаботе");
        public EnumItem Подготовлен => GetProperty<EnumItem>("Подготовлен");
        public EnumItem ПереданВФСС => GetProperty<EnumItem>("ПереданВФСС");
        public EnumItem ПринятФСС => GetProperty<EnumItem>("ПринятФСС");
        public EnumItem НеПринятФСС => GetProperty<EnumItem>("НеПринятФСС");
        public EnumItem Аннулирован => GetProperty<EnumItem>("Аннулирован");
    }
}
