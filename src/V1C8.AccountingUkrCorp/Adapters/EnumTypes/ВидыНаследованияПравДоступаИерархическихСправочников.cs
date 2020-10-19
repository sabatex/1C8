using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНаследованияПравДоступаИерархическихСправочников:EnumBase
    {
        public ВидыНаследованияПравДоступаИерархическихСправочников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НаследуетсяОтРодителя => GetProperty<EnumItem>("НаследуетсяОтРодителя");
        public EnumItem РаспространитьНаПодчиненных => GetProperty<EnumItem>("РаспространитьНаПодчиненных");
        public EnumItem ТолькоДляТекущегоПрава => GetProperty<EnumItem>("ТолькоДляТекущегоПрава");
    }
}
