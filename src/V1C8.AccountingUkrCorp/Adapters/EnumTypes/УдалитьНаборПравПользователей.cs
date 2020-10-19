using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьНаборПравПользователей:EnumBase
    {
        public УдалитьНаборПравПользователей(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Бухгалтер => GetProperty<EnumItem>("Бухгалтер");
        public EnumItem ГлавныйБухгалтер => GetProperty<EnumItem>("ГлавныйБухгалтер");
        public EnumItem ПолныеПрава => GetProperty<EnumItem>("ПолныеПрава");
    }
}
