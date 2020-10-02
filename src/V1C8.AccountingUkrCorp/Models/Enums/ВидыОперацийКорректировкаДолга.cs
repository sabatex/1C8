using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийКорректировкаДолга", Comment = "(Общ)", Synonym = "Виды операций документа 'Корректировка долга по возвратной таре'")]
    public class ВидыОперацийКорректировкаДолга:EnumItem
    {
        public static readonly ВидыОперацийКорректировкаДолга ПереносЗадолженности = new ВидыОперацийКорректировкаДолга{Name= "ПереносЗадолженности",Synonim="Перенос задолженности",Comment="(Общ)"};
        public static readonly ВидыОперацийКорректировкаДолга СписаниеЗадолженности = new ВидыОперацийКорректировкаДолга{Name= "СписаниеЗадолженности",Synonim="Списание безнадежной задолженности",Comment=""};
        public static readonly ВидыОперацийКорректировкаДолга ИзменениеЗадолженности = new ВидыОперацийКорректировкаДолга{Name= "ИзменениеЗадолженности",Synonim="Изменение (формирование) задолженности",Comment=""};
        public static readonly ВидыОперацийКорректировкаДолга ПроведениеВзаимозачета = new ВидыОперацийКорректировкаДолга{Name= "ПроведениеВзаимозачета",Synonim="Проведение взаимозачета",Comment="(Общ)"};
        public static readonly ВидыОперацийКорректировкаДолга ВводНачальныхОстатков = new ВидыОперацийКорректировкаДолга{Name= "ВводНачальныхОстатков",Synonim="Ввод начальных остатков",Comment=""};
    }
}
