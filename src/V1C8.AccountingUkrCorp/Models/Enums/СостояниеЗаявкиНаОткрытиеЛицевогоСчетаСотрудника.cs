using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("SostoianyeZaiavkyNaOtkrytyeLytsevohoSchetaSotrudnyka")]
    [Description1C8(Name = "СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника", Comment = "", Synonym = "Состояние заявки на открытие лицевого счета сотрудника")]
    public class СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника:EnumItem
    {
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ЗаявкаНеЗаполнена = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ЗаявкаНеЗаполнена",Synonym="Заявка не заполнена",Comment=""};
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ОжидаетПодтверждения = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ОжидаетПодтверждения",Synonym="Выгружен в банк",Comment=""};
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ГотовКВыгрузке = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ГотовКВыгрузке",Synonym="Готов к выгрузке",Comment=""};
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ОтложеноОткрытиеЛицевогоСчета = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ОтложеноОткрытиеЛицевогоСчета",Synonym="Отложено открытие лицевого счета",Comment=""};
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ЛицевойСчетНеОткрыт = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ЛицевойСчетНеОткрыт",Synonym="Лицевой счет не открыт",Comment=""};
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ЛицевыеСчетаОткрыты = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ЛицевыеСчетаОткрыты",Synonym="Лицевые счета открыты",Comment=""};
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ЛицевыеСчетаОткрытыСОшибками = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ЛицевыеСчетаОткрытыСОшибками",Synonym="Лицевые счета открыты (частично)",Comment=""};
        public static readonly СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника ЛицевыеСчетаНеОткрыты = new СостояниеЗаявкиНаОткрытиеЛицевогоСчетаСотрудника{Name= "ЛицевыеСчетаНеОткрыты",Synonym="Лицевые счета не открыты (все строки - ошибки)",Comment=""};
    }
}
