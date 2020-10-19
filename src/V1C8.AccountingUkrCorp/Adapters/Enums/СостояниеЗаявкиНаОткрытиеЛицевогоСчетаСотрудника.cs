using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника:V1C8COMObject
    {
        public СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаявкаНеЗаполнена => GetProperty<EnumItemBase>();
        public EnumItemBase ОжидаетПодтверждения => GetProperty<EnumItemBase>();
        public EnumItemBase ГотовКВыгрузке => GetProperty<EnumItemBase>();
        public EnumItemBase ОтложеноОткрытиеЛицевогоСчета => GetProperty<EnumItemBase>();
        public EnumItemBase ЛицевойСчетНеОткрыт => GetProperty<EnumItemBase>();
        public EnumItemBase ЛицевыеСчетаОткрыты => GetProperty<EnumItemBase>();
        public EnumItemBase ЛицевыеСчетаОткрытыСОшибками => GetProperty<EnumItemBase>();
        public EnumItemBase ЛицевыеСчетаНеОткрыты => GetProperty<EnumItemBase>();
    }
}
