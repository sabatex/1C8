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
    [Table("VydyNasledovanyiaPravDostupaYerarkhycheskykhSpravochnykov")]
    [Description1C8(Name = "ВидыНаследованияПравДоступаИерархическихСправочников", Comment = "", Synonym = "Виды наследования прав доступа иерархических справочников")]
    public class ВидыНаследованияПравДоступаИерархическихСправочников:EnumItem
    {
        public static readonly ВидыНаследованияПравДоступаИерархическихСправочников НаследуетсяОтРодителя = new ВидыНаследованияПравДоступаИерархическихСправочников{Name= "НаследуетсяОтРодителя",Synonym="Наследуется от родителя",Comment=""};
        public static readonly ВидыНаследованияПравДоступаИерархическихСправочников РаспространитьНаПодчиненных = new ВидыНаследованияПравДоступаИерархическихСправочников{Name= "РаспространитьНаПодчиненных",Synonym="Распространить на подчиненных",Comment=""};
        public static readonly ВидыНаследованияПравДоступаИерархическихСправочников ТолькоДляТекущегоПрава = new ВидыНаследованияПравДоступаИерархическихСправочников{Name= "ТолькоДляТекущегоПрава",Synonym="Только для текущего права",Comment=""};
    }
}
