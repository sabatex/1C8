using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьДействиеПриОбмене:V1C8COMObject
    {
        public УдалитьДействиеПриОбмене(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗагрузкаДанных => GetProperty<EnumItemBase>("ЗагрузкаДанных");
        public EnumItemBase ОтложенныеДвижения => GetProperty<EnumItemBase>("ОтложенныеДвижения");
        public EnumItemBase ВыгрузкаДанных => GetProperty<EnumItemBase>("ВыгрузкаДанных");
    }
}
