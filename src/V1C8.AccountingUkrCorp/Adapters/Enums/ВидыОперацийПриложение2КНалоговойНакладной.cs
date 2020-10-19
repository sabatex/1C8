using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПриложение2КНалоговойНакладной:V1C8COMObject
    {
        public ВидыОперацийПриложение2КНалоговойНакладной(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОблагаемыеОперацииВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase ОблагаемыеОперацииКорректировка => GetProperty<EnumItemBase>();
        public EnumItemBase ОсвобожденныеОперацииВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase ОсвобожденныеОперацииКорректировка => GetProperty<EnumItemBase>();
        public EnumItemBase НеНДСОперацииВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase НеНДСОперацииКорректировка => GetProperty<EnumItemBase>();
        public EnumItemBase ИтоговаяРозницаОблагаемыеОперацииВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase ИтоговаяРозницаОсвобожденныеОперацииВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase РозницаКонрагентуОблагаемыеОперацииВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase РозницаКонрагентуОсвобожденныеОперацииВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase РаботыОтНерезидентаКорректировка => GetProperty<EnumItemBase>();
        public EnumItemBase УсловнаяПродажаВозврат => GetProperty<EnumItemBase>();
        public EnumItemBase СводнаяНаПревышениеБазыНадЦенойПоставки => GetProperty<EnumItemBase>();
    }
}
