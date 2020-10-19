using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РезультатыВыполненияОбмена:V1C8COMObject
    {
        public РезультатыВыполненияОбмена(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Выполнено => GetProperty<EnumItemBase>();
        public EnumItemBase Отменено => GetProperty<EnumItemBase>();
        public EnumItemBase Ошибка => GetProperty<EnumItemBase>();
        public EnumItemBase Ошибка_ТранспортСообщения => GetProperty<EnumItemBase>();
        public EnumItemBase Предупреждение_СообщениеОбменаБылоРанееПринято => GetProperty<EnumItemBase>();
        public EnumItemBase ВыполненоСПредупреждениями => GetProperty<EnumItemBase>();
    }
}
