using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РезультатыВыполненияОбмена:EnumBase
    {
        public РезультатыВыполненияОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Выполнено => GetProperty<EnumItem>("Выполнено");
        public EnumItem Отменено => GetProperty<EnumItem>("Отменено");
        public EnumItem Ошибка => GetProperty<EnumItem>("Ошибка");
        public EnumItem Ошибка_ТранспортСообщения => GetProperty<EnumItem>("Ошибка_ТранспортСообщения");
        public EnumItem Предупреждение_СообщениеОбменаБылоРанееПринято => GetProperty<EnumItem>("Предупреждение_СообщениеОбменаБылоРанееПринято");
        public EnumItem ВыполненоСПредупреждениями => GetProperty<EnumItem>("ВыполненоСПредупреждениями");
    }
}
