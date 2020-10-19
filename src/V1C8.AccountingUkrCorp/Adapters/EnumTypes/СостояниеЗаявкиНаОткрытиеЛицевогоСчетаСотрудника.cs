using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника:V1C8COMObject
    {
        public СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗаявкаНеЗаполнена => GetProperty<EnumItemBase>("ЗаявкаНеЗаполнена");
        public EnumItemBase ОжидаетПодтверждения => GetProperty<EnumItemBase>("ОжидаетПодтверждения");
        public EnumItemBase ГотовКВыгрузке => GetProperty<EnumItemBase>("ГотовКВыгрузке");
        public EnumItemBase ОтложеноОткрытиеЛицевогоСчета => GetProperty<EnumItemBase>("ОтложеноОткрытиеЛицевогоСчета");
        public EnumItemBase ЛицевойСчетНеОткрыт => GetProperty<EnumItemBase>("ЛицевойСчетНеОткрыт");
        public EnumItemBase ЛицевыеСчетаОткрыты => GetProperty<EnumItemBase>("ЛицевыеСчетаОткрыты");
        public EnumItemBase ЛицевыеСчетаОткрытыСОшибками => GetProperty<EnumItemBase>("ЛицевыеСчетаОткрытыСОшибками");
        public EnumItemBase ЛицевыеСчетаНеОткрыты => GetProperty<EnumItemBase>("ЛицевыеСчетаНеОткрыты");
    }
}
