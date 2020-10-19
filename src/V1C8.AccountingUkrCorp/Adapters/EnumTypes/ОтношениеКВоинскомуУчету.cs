using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОтношениеКВоинскомуУчету:EnumBase
    {
        public ОтношениеКВоинскомуУчету(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Состоит => GetProperty<EnumItem>("Состоит");
        public EnumItem Встает => GetProperty<EnumItem>("Встает");
        public EnumItem НеСостоит => GetProperty<EnumItem>("НеСостоит");
        public EnumItem СнятПоВозрасту => GetProperty<EnumItem>("СнятПоВозрасту");
        public EnumItem СнятПоСостояниюЗдоровья => GetProperty<EnumItem>("СнятПоСостояниюЗдоровья");
        public EnumItem ПризванНаВоинскуюСлужбу => GetProperty<EnumItem>("ПризванНаВоинскуюСлужбу");
        public EnumItem СлужбаПоКонтракту => GetProperty<EnumItem>("СлужбаПоКонтракту");
    }
}
