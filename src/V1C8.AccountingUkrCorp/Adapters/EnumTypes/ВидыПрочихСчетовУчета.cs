using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПрочихСчетовУчета:EnumBase
    {
        public ВидыПрочихСчетовУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СчетДоходовВозвратПоставщику => GetProperty<EnumItem>("СчетДоходовВозвратПоставщику");
        public EnumItem СчетЗатратВозвратПоставщику => GetProperty<EnumItem>("СчетЗатратВозвратПоставщику");
        public EnumItem СчетЗатратОтчетКомиссионераОПродажах => GetProperty<EnumItem>("СчетЗатратОтчетКомиссионераОПродажах");
        public EnumItem СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты => GetProperty<EnumItem>("СчетЗатратКурсоваяРазницаПокупкаПродажаВалюты");
        public EnumItem СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты => GetProperty<EnumItem>("СчетДоходовКурсоваяРазницаПокупкаПродажаВалюты");
        public EnumItem СчетЗатратКомиссионныеПокупкаПродажаВалюты => GetProperty<EnumItem>("СчетЗатратКомиссионныеПокупкаПродажаВалюты");
        public EnumItem СчетЗатратПенсионныйПродажаВалюты => GetProperty<EnumItem>("СчетЗатратПенсионныйПродажаВалюты");
        public EnumItem СчетЗатратСебестоимостьПродажаВалюты => GetProperty<EnumItem>("СчетЗатратСебестоимостьПродажаВалюты");
        public EnumItem СчетДоходовСебестоимостьПродажаВалюты => GetProperty<EnumItem>("СчетДоходовСебестоимостьПродажаВалюты");
        public EnumItem СчетДтСписаниеЗадолженностиКорректировкаДолга => GetProperty<EnumItem>("СчетДтСписаниеЗадолженностиКорректировкаДолга");
        public EnumItem СчетКтСписаниеЗадолженностиКорректировкаДолга => GetProperty<EnumItem>("СчетКтСписаниеЗадолженностиКорректировкаДолга");
    }
}
