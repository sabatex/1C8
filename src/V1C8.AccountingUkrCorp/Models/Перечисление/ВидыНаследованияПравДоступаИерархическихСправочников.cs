using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНаследованияПравДоступаИерархическихСправочников", Comment = "", Synonym = "Виды наследования прав доступа иерархических справочников")]
    public enum ВидыНаследованияПравДоступаИерархическихСправочников
    {
        [Description1C8(Name = "НаследуетсяОтРодителя", Comment = "", Synonym = "Наследуется от родителя")]
        НаследуетсяОтРодителя,
        [Description1C8(Name = "РаспространитьНаПодчиненных", Comment = "", Synonym = "Распространить на подчиненных")]
        РаспространитьНаПодчиненных,
        [Description1C8(Name = "ТолькоДляТекущегоПрава", Comment = "", Synonym = "Только для текущего права")]
        ТолькоДляТекущегоПрава
    }
}
