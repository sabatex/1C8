using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыМонитораРуководителя:EnumBase
    {
        public РазделыМонитораРуководителя(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОстаткиДенежныхСредств => GetProperty<EnumItem>("ОстаткиДенежныхСредств");
        public EnumItem ДвижениеДенежныхСредств => GetProperty<EnumItem>("ДвижениеДенежныхСредств");
        public EnumItem ПродажиПоКонтрагентам => GetProperty<EnumItem>("ПродажиПоКонтрагентам");
        public EnumItem ПродажиПоНоменклатурнымГруппам => GetProperty<EnumItem>("ПродажиПоНоменклатурнымГруппам");
        public EnumItem ЗадолженностьПокупателей => GetProperty<EnumItem>("ЗадолженностьПокупателей");
        public EnumItem ПросроченнаяЗадолженностьПокупателей => GetProperty<EnumItem>("ПросроченнаяЗадолженностьПокупателей");
        public EnumItem ЗадолженностьПоставщикам => GetProperty<EnumItem>("ЗадолженностьПоставщикам");
        public EnumItem ПросроченнаяЗадолженностьПоставщикам => GetProperty<EnumItem>("ПросроченнаяЗадолженностьПоставщикам");
    }
}
