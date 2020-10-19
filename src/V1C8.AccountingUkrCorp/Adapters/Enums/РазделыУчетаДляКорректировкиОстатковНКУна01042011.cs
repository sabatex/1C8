using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РазделыУчетаДляКорректировкиОстатковНКУна01042011:V1C8COMObject
    {
        public РазделыУчетаДляКорректировкиОстатковНКУна01042011(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновныеСредства => GetProperty<EnumItemBase>();
        public EnumItemBase МалоценныеАктивыВЭксплуатации => GetProperty<EnumItemBase>();
        public EnumItemBase НематериальныеАктивы => GetProperty<EnumItemBase>();
        public EnumItemBase КапитальныеИнвестиции => GetProperty<EnumItemBase>();
        public EnumItemBase ЗапасыСебестоимость => GetProperty<EnumItemBase>();
        public EnumItemBase ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах => GetProperty<EnumItemBase>();
        public EnumItemBase ЗапасыПереданные => GetProperty<EnumItemBase>();
        public EnumItemBase НезавершенноеПроизводство => GetProperty<EnumItemBase>();
        public EnumItemBase ТоварыПоПродажнойЦене => GetProperty<EnumItemBase>();
        public EnumItemBase РасходыБудущихПериодов => GetProperty<EnumItemBase>();
    }
}
