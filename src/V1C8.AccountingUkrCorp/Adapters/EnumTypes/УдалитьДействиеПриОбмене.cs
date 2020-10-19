using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьДействиеПриОбмене:EnumBase
    {
        public УдалитьДействиеПриОбмене(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЗагрузкаДанных => GetProperty<EnumItem>("ЗагрузкаДанных");
        public EnumItem ОтложенныеДвижения => GetProperty<EnumItem>("ОтложенныеДвижения");
        public EnumItem ВыгрузкаДанных => GetProperty<EnumItem>("ВыгрузкаДанных");
    }
}
