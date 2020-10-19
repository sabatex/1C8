using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьНаборПравПользователей:V1C8COMObject
    {
        public УдалитьНаборПравПользователей(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Бухгалтер => GetProperty<EnumItemBase>();
        public EnumItemBase ГлавныйБухгалтер => GetProperty<EnumItemBase>();
        public EnumItemBase ПолныеПрава => GetProperty<EnumItemBase>();
    }
}
