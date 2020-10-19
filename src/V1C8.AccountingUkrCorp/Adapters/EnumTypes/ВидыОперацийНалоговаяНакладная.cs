using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийНалоговаяНакладная:EnumBase
    {
        public ВидыОперацийНалоговаяНакладная(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОблагаемыеОперации => GetProperty<EnumItem>("ОблагаемыеОперации");
        public EnumItem ОсвобожденныеОперации => GetProperty<EnumItem>("ОсвобожденныеОперации");
        public EnumItem НеНДСОперации => GetProperty<EnumItem>("НеНДСОперации");
        public EnumItem ИтоговаяРозницаОблагаемыеОперации => GetProperty<EnumItem>("ИтоговаяРозницаОблагаемыеОперации");
        public EnumItem ИтоговаяРозницаОсвобожденныеОперации => GetProperty<EnumItem>("ИтоговаяРозницаОсвобожденныеОперации");
        public EnumItem РозницаКонрагентуОблагаемыеОперации => GetProperty<EnumItem>("РозницаКонрагентуОблагаемыеОперации");
        public EnumItem РозницаКонрагентуОсвобожденныеОперации => GetProperty<EnumItem>("РозницаКонрагентуОсвобожденныеОперации");
        public EnumItem УсловнаяПродажа => GetProperty<EnumItem>("УсловнаяПродажа");
        public EnumItem УсловнаяПродажаСписаниеОС => GetProperty<EnumItem>("УсловнаяПродажаСписаниеОС");
        public EnumItem РаботыОтНерезидента => GetProperty<EnumItem>("РаботыОтНерезидента");
        public EnumItem СводнаяНаПревышениеБазыНадЦенойПоставки => GetProperty<EnumItem>("СводнаяНаПревышениеБазыНадЦенойПоставки");
    }
}
