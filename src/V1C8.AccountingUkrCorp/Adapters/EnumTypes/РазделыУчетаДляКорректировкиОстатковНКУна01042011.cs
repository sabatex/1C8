using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыУчетаДляКорректировкиОстатковНКУна01042011:V1C8COMObject
    {
        public РазделыУчетаДляКорректировкиОстатковНКУна01042011(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновныеСредства => GetProperty<EnumItemBase>("ОсновныеСредства");
        public EnumItemBase МалоценныеАктивыВЭксплуатации => GetProperty<EnumItemBase>("МалоценныеАктивыВЭксплуатации");
        public EnumItemBase НематериальныеАктивы => GetProperty<EnumItemBase>("НематериальныеАктивы");
        public EnumItemBase КапитальныеИнвестиции => GetProperty<EnumItemBase>("КапитальныеИнвестиции");
        public EnumItemBase ЗапасыСебестоимость => GetProperty<EnumItemBase>("ЗапасыСебестоимость");
        public EnumItemBase ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах => GetProperty<EnumItemBase>("ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах");
        public EnumItemBase ЗапасыПереданные => GetProperty<EnumItemBase>("ЗапасыПереданные");
        public EnumItemBase НезавершенноеПроизводство => GetProperty<EnumItemBase>("НезавершенноеПроизводство");
        public EnumItemBase ТоварыПоПродажнойЦене => GetProperty<EnumItemBase>("ТоварыПоПродажнойЦене");
        public EnumItemBase РасходыБудущихПериодов => GetProperty<EnumItemBase>("РасходыБудущихПериодов");
    }
}
