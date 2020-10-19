using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыХраненияМногостраничныхФайлов:V1C8COMObject
    {
        public ФорматыХраненияМногостраничныхФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase PDF => GetProperty<EnumItemBase>("PDF");
        public EnumItemBase TIF => GetProperty<EnumItemBase>("TIF");
    }
}
