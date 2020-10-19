using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ОтношениеКВоинскомуУчету:V1C8COMObject
    {
        public ОтношениеКВоинскомуУчету(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Состоит => GetProperty<EnumItemBase>();
        public EnumItemBase Встает => GetProperty<EnumItemBase>();
        public EnumItemBase НеСостоит => GetProperty<EnumItemBase>();
        public EnumItemBase СнятПоВозрасту => GetProperty<EnumItemBase>();
        public EnumItemBase СнятПоСостояниюЗдоровья => GetProperty<EnumItemBase>();
        public EnumItemBase ПризванНаВоинскуюСлужбу => GetProperty<EnumItemBase>();
        public EnumItemBase СлужбаПоКонтракту => GetProperty<EnumItemBase>();
    }
}
