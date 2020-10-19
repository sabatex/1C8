using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РезультатыВыполненияОбмена:V1C8COMObject
    {
        public РезультатыВыполненияОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Выполнено => GetProperty<EnumItemBase>("Выполнено");
        public EnumItemBase Отменено => GetProperty<EnumItemBase>("Отменено");
        public EnumItemBase Ошибка => GetProperty<EnumItemBase>("Ошибка");
        public EnumItemBase Ошибка_ТранспортСообщения => GetProperty<EnumItemBase>("Ошибка_ТранспортСообщения");
        public EnumItemBase Предупреждение_СообщениеОбменаБылоРанееПринято => GetProperty<EnumItemBase>("Предупреждение_СообщениеОбменаБылоРанееПринято");
        public EnumItemBase ВыполненоСПредупреждениями => GetProperty<EnumItemBase>("ВыполненоСПредупреждениями");
    }
}
