using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника:EnumBase
    {
        public СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЗаявкаНеЗаполнена => GetProperty<EnumItem>("ЗаявкаНеЗаполнена");
        public EnumItem ОжидаетПодтверждения => GetProperty<EnumItem>("ОжидаетПодтверждения");
        public EnumItem ГотовКВыгрузке => GetProperty<EnumItem>("ГотовКВыгрузке");
        public EnumItem ОтложеноОткрытиеЛицевогоСчета => GetProperty<EnumItem>("ОтложеноОткрытиеЛицевогоСчета");
        public EnumItem ЛицевойСчетНеОткрыт => GetProperty<EnumItem>("ЛицевойСчетНеОткрыт");
        public EnumItem ЛицевыеСчетаОткрыты => GetProperty<EnumItem>("ЛицевыеСчетаОткрыты");
        public EnumItem ЛицевыеСчетаОткрытыСОшибками => GetProperty<EnumItem>("ЛицевыеСчетаОткрытыСОшибками");
        public EnumItem ЛицевыеСчетаНеОткрыты => GetProperty<EnumItem>("ЛицевыеСчетаНеОткрыты");
    }
}
