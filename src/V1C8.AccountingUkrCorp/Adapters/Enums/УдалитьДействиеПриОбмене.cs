using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьДействиеПриОбмене:V1C8COMObject
    {
        public УдалитьДействиеПриОбмене(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗагрузкаДанных => GetProperty<EnumItemBase>();
        public EnumItemBase ОтложенныеДвижения => GetProperty<EnumItemBase>();
        public EnumItemBase ВыгрузкаДанных => GetProperty<EnumItemBase>();
    }
}
