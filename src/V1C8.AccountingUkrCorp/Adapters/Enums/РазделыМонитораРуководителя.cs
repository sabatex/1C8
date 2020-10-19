using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РазделыМонитораРуководителя:V1C8COMObject
    {
        public РазделыМонитораРуководителя(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОстаткиДенежныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase ДвижениеДенежныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase ПродажиПоКонтрагентам => GetProperty<EnumItemBase>();
        public EnumItemBase ПродажиПоНоменклатурнымГруппам => GetProperty<EnumItemBase>();
        public EnumItemBase ЗадолженностьПокупателей => GetProperty<EnumItemBase>();
        public EnumItemBase ПросроченнаяЗадолженностьПокупателей => GetProperty<EnumItemBase>();
        public EnumItemBase ЗадолженностьПоставщикам => GetProperty<EnumItemBase>();
        public EnumItemBase ПросроченнаяЗадолженностьПоставщикам => GetProperty<EnumItemBase>();
    }
}
