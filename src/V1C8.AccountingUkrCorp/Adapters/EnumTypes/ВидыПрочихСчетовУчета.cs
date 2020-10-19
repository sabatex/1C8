using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПрочихСчетовУчета:V1C8COMObject
    {
        public ВидыПрочихСчетовУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СчетДоходовВозвратПоставщику => GetProperty<EnumItemBase>("СчетДоходовВозвратПоставщику");
        public EnumItemBase СчетЗатратВозвратПоставщику => GetProperty<EnumItemBase>("СчетЗатратВозвратПоставщику");
        public EnumItemBase СчетЗатратОтчетКомиссионераОПродажах => GetProperty<EnumItemBase>("СчетЗатратОтчетКомиссионераОПродажах");
        public EnumItemBase СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты => GetProperty<EnumItemBase>("СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты");
        public EnumItemBase СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты => GetProperty<EnumItemBase>("СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты");
        public EnumItemBase СчетЗатратКомиссионныеПокупкаПродажаВалюты => GetProperty<EnumItemBase>("СчетЗатратКомиссионныеПокупкаПродажаВалюты");
        public EnumItemBase СчетЗатратПенсионныйПродажаВалюты => GetProperty<EnumItemBase>("СчетЗатратПенсионныйПродажаВалюты");
        public EnumItemBase СчетЗатратСебестоимостьПродажаВалюты => GetProperty<EnumItemBase>("СчетЗатратСебестоимостьПродажаВалюты");
        public EnumItemBase СчетДоходовСебестоимостьПродажаВалюты => GetProperty<EnumItemBase>("СчетДоходовСебестоимостьПродажаВалюты");
        public EnumItemBase СчетДтСписаниеЗадолженностиКорректировкаДолга => GetProperty<EnumItemBase>("СчетДтСписаниеЗадолженностиКорректировкаДолга");
        public EnumItemBase СчетКтСписаниеЗадолженностиКорректировкаДолга => GetProperty<EnumItemBase>("СчетКтСписаниеЗадолженностиКорректировкаДолга");
    }
}
