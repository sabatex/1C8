using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыПрочихСчетовУчета:V1C8COMObject
    {
        public ВидыПрочихСчетовУчета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СчетДоходовВозвратПоставщику => GetProperty<EnumItemBase>();
        public EnumItemBase СчетЗатратВозвратПоставщику => GetProperty<EnumItemBase>();
        public EnumItemBase СчетЗатратОтчетКомиссионераОПродажах => GetProperty<EnumItemBase>();
        public EnumItemBase СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase СчетЗатратКомиссионныеПокупкаПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase СчетЗатратПенсионныйПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase СчетЗатратСебестоимостьПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase СчетДоходовСебестоимостьПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase СчетДтСписаниеЗадолженностиКорректировкаДолга => GetProperty<EnumItemBase>();
        public EnumItemBase СчетКтСписаниеЗадолженностиКорректировкаДолга => GetProperty<EnumItemBase>();
    }
}
