using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПриложение2КНалоговойНакладной:V1C8COMObject
    {
        public ВидыОперацийПриложение2КНалоговойНакладной(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОблагаемыеОперацииВозврат => GetProperty<EnumItemBase>("ОблагаемыеОперацииВозврат");
        public EnumItemBase ОблагаемыеОперацииКорректировка => GetProperty<EnumItemBase>("ОблагаемыеОперацииКорректировка");
        public EnumItemBase ОсвобожденныеОперацииВозврат => GetProperty<EnumItemBase>("ОсвобожденныеОперацииВозврат");
        public EnumItemBase ОсвобожденныеОперацииКорректировка => GetProperty<EnumItemBase>("ОсвобожденныеОперацииКорректировка");
        public EnumItemBase НеНДСОперацииВозврат => GetProperty<EnumItemBase>("НеНДСОперацииВозврат");
        public EnumItemBase НеНДСОперацииКорректировка => GetProperty<EnumItemBase>("НеНДСОперацииКорректировка");
        public EnumItemBase ИтоговаяРозницаОблагаемыеОперацииВозврат => GetProperty<EnumItemBase>("ИтоговаяРозницаОблагаемыеОперацииВозврат");
        public EnumItemBase ИтоговаяРозницаОсвобожденныеОперацииВозврат => GetProperty<EnumItemBase>("ИтоговаяРозницаОсвобожденныеОперацииВозврат");
        public EnumItemBase РозницаКонрагентуОблагаемыеОперацииВозврат => GetProperty<EnumItemBase>("РозницаКонрагентуОблагаемыеОперацииВозврат");
        public EnumItemBase РозницаКонрагентуОсвобожденныеОперацииВозврат => GetProperty<EnumItemBase>("РозницаКонрагентуОсвобожденныеОперацииВозврат");
        public EnumItemBase РаботыОтНерезидентаКорректировка => GetProperty<EnumItemBase>("РаботыОтНерезидентаКорректировка");
        public EnumItemBase УсловнаяПродажаВозврат => GetProperty<EnumItemBase>("УсловнаяПродажаВозврат");
        public EnumItemBase СводнаяНаПревышениеБазыНадЦенойПоставки => GetProperty<EnumItemBase>("СводнаяНаПревышениеБазыНадЦенойПоставки");
    }
}
