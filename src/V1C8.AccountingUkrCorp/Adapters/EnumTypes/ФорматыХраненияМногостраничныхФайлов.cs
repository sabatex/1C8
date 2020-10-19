using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыХраненияМногостраничныхФайлов:EnumBase
    {
        public ФорматыХраненияМногостраничныхФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem PDF => GetProperty<EnumItem>("PDF");
        public EnumItem TIF => GetProperty<EnumItem>("TIF");
    }
}
