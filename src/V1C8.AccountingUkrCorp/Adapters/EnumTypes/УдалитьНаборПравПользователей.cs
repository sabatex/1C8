using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьНаборПравПользователей:V1C8COMObject
    {
        public УдалитьНаборПравПользователей(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Бухгалтер => GetProperty<EnumItemBase>("Бухгалтер");
        public EnumItemBase ГлавныйБухгалтер => GetProperty<EnumItemBase>("ГлавныйБухгалтер");
        public EnumItemBase ПолныеПрава => GetProperty<EnumItemBase>("ПолныеПрава");
    }
}
