using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОтношениеКВоинскомуУчету:V1C8COMObject
    {
        public ОтношениеКВоинскомуУчету(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Состоит => GetProperty<EnumItemBase>("Состоит");
        public EnumItemBase Встает => GetProperty<EnumItemBase>("Встает");
        public EnumItemBase НеСостоит => GetProperty<EnumItemBase>("НеСостоит");
        public EnumItemBase СнятПоВозрасту => GetProperty<EnumItemBase>("СнятПоВозрасту");
        public EnumItemBase СнятПоСостояниюЗдоровья => GetProperty<EnumItemBase>("СнятПоСостояниюЗдоровья");
        public EnumItemBase ПризванНаВоинскуюСлужбу => GetProperty<EnumItemBase>("ПризванНаВоинскуюСлужбу");
        public EnumItemBase СлужбаПоКонтракту => GetProperty<EnumItemBase>("СлужбаПоКонтракту");
    }
}
