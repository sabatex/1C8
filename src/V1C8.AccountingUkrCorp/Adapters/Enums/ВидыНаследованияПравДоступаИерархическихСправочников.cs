using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыНаследованияПравДоступаИерархическихСправочников:V1C8COMObject
    {
        public ВидыНаследованияПравДоступаИерархическихСправочников(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НаследуетсяОтРодителя => GetProperty<EnumItemBase>();
        public EnumItemBase РаспространитьНаПодчиненных => GetProperty<EnumItemBase>();
        public EnumItemBase ТолькоДляТекущегоПрава => GetProperty<EnumItemBase>();
    }
}
