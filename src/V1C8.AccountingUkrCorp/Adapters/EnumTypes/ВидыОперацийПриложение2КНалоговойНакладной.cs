using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПриложение2КНалоговойНакладной:EnumBase
    {
        public ВидыОперацийПриложение2КНалоговойНакладной(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОблагаемыеОперацииВозврат => GetProperty<EnumItem>("ОблагаемыеОперацииВозврат");
        public EnumItem ОблагаемыеОперацииКорректировка => GetProperty<EnumItem>("ОблагаемыеОперацииКорректировка");
        public EnumItem ОсвобожденныеОперацииВозврат => GetProperty<EnumItem>("ОсвобожденныеОперацииВозврат");
        public EnumItem ОсвобожденныеОперацииКорректировка => GetProperty<EnumItem>("ОсвобожденныеОперацииКорректировка");
        public EnumItem НеНДСОперацииВозврат => GetProperty<EnumItem>("НеНДСОперацииВозврат");
        public EnumItem НеНДСОперацииКорректировка => GetProperty<EnumItem>("НеНДСОперацииКорректировка");
        public EnumItem ИтоговаяРозницаОблагаемыеОперацииВозврат => GetProperty<EnumItem>("ИтоговаяРозницаОблагаемыеОперацииВозврат");
        public EnumItem ИтоговаяРозницаОсвобожденныеОперацииВозврат => GetProperty<EnumItem>("ИтоговаяРозницаОсвобожденныеОперацииВозврат");
        public EnumItem РозницаКонрагентуОблагаемыеОперацииВозврат => GetProperty<EnumItem>("РозницаКонрагентуОблагаемыеОперацииВозврат");
        public EnumItem РозницаКонрагентуОсвобожденныеОперацииВозврат => GetProperty<EnumItem>("РозницаКонрагентуОсвобожденныеОперацииВозврат");
        public EnumItem РаботыОтНерезидентаКорректировка => GetProperty<EnumItem>("РаботыОтНерезидентаКорректировка");
        public EnumItem УсловнаяПродажаВозврат => GetProperty<EnumItem>("УсловнаяПродажаВозврат");
        public EnumItem СводнаяНаПревышениеБазыНадЦенойПоставки => GetProperty<EnumItem>("СводнаяНаПревышениеБазыНадЦенойПоставки");
    }
}
