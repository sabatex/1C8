using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыМонитораРуководителя:V1C8COMObject
    {
        public РазделыМонитораРуководителя(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОстаткиДенежныхСредств => GetProperty<EnumItemBase>("ОстаткиДенежныхСредств");
        public EnumItemBase ДвижениеДенежныхСредств => GetProperty<EnumItemBase>("ДвижениеДенежныхСредств");
        public EnumItemBase ПродажиПоКонтрагентам => GetProperty<EnumItemBase>("ПродажиПоКонтрагентам");
        public EnumItemBase ПродажиПоНоменклатурнымГруппам => GetProperty<EnumItemBase>("ПродажиПоНоменклатурнымГруппам");
        public EnumItemBase ЗадолженностьПокупателей => GetProperty<EnumItemBase>("ЗадолженностьПокупателей");
        public EnumItemBase ПросроченнаяЗадолженностьПокупателей => GetProperty<EnumItemBase>("ПросроченнаяЗадолженностьПокупателей");
        public EnumItemBase ЗадолженностьПоставщикам => GetProperty<EnumItemBase>("ЗадолженностьПоставщикам");
        public EnumItemBase ПросроченнаяЗадолженностьПоставщикам => GetProperty<EnumItemBase>("ПросроченнаяЗадолженностьПоставщикам");
    }
}
