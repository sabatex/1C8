using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийНалоговаяНакладная:V1C8COMObject
    {
        public ВидыОперацийНалоговаяНакладная(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОблагаемыеОперации => GetProperty<EnumItemBase>("ОблагаемыеОперации");
        public EnumItemBase ОсвобожденныеОперации => GetProperty<EnumItemBase>("ОсвобожденныеОперации");
        public EnumItemBase НеНДСОперации => GetProperty<EnumItemBase>("НеНДСОперации");
        public EnumItemBase ИтоговаяРозницаОблагаемыеОперации => GetProperty<EnumItemBase>("ИтоговаяРозницаОблагаемыеОперации");
        public EnumItemBase ИтоговаяРозницаОсвобожденныеОперации => GetProperty<EnumItemBase>("ИтоговаяРозницаОсвобожденныеОперации");
        public EnumItemBase РозницаКонрагентуОблагаемыеОперации => GetProperty<EnumItemBase>("РозницаКонрагентуОблагаемыеОперации");
        public EnumItemBase РозницаКонрагентуОсвобожденныеОперации => GetProperty<EnumItemBase>("РозницаКонрагентуОсвобожденныеОперации");
        public EnumItemBase УсловнаяПродажа => GetProperty<EnumItemBase>("УсловнаяПродажа");
        public EnumItemBase УсловнаяПродажаСписаниеОС => GetProperty<EnumItemBase>("УсловнаяПродажаСписаниеОС");
        public EnumItemBase РаботыОтНерезидента => GetProperty<EnumItemBase>("РаботыОтНерезидента");
        public EnumItemBase СводнаяНаПревышениеБазыНадЦенойПоставки => GetProperty<EnumItemBase>("СводнаяНаПревышениеБазыНадЦенойПоставки");
    }
}
