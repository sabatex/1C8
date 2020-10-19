using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыУчетаДляКорректировкиОстатковНКУна01042011:EnumBase
    {
        public РазделыУчетаДляКорректировкиОстатковНКУна01042011(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОсновныеСредства => GetProperty<EnumItem>("ОсновныеСредства");
        public EnumItem МалоценныеАктивыВЭксплуатации => GetProperty<EnumItem>("МалоценныеАктивыВЭксплуатации");
        public EnumItem НематериальныеАктивы => GetProperty<EnumItem>("НематериальныеАктивы");
        public EnumItem КапитальныеИнвестиции => GetProperty<EnumItem>("КапитальныеИнвестиции");
        public EnumItem ЗапасыСебестоимость => GetProperty<EnumItem>("ЗапасыСебестоимость");
        public EnumItem ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах => GetProperty<EnumItem>("ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах");
        public EnumItem ЗапасыПереданные => GetProperty<EnumItem>("ЗапасыПереданные");
        public EnumItem НезавершенноеПроизводство => GetProperty<EnumItem>("НезавершенноеПроизводство");
        public EnumItem ТоварыПоПродажнойЦене => GetProperty<EnumItem>("ТоварыПоПродажнойЦене");
        public EnumItem РасходыБудущихПериодов => GetProperty<EnumItem>("РасходыБудущихПериодов");
    }
}
