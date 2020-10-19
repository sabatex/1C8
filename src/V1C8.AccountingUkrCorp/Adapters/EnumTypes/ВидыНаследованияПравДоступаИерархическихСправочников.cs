using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНаследованияПравДоступаИерархическихСправочников:V1C8COMObject
    {
        public ВидыНаследованияПравДоступаИерархическихСправочников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НаследуетсяОтРодителя => GetProperty<EnumItemBase>("НаследуетсяОтРодителя");
        public EnumItemBase РаспространитьНаПодчиненных => GetProperty<EnumItemBase>("РаспространитьНаПодчиненных");
        public EnumItemBase ТолькоДляТекущегоПрава => GetProperty<EnumItemBase>("ТолькоДляТекущегоПрава");
    }
}
