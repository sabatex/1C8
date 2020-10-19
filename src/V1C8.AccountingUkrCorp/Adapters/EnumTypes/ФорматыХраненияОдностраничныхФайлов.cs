using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыХраненияОдностраничныхФайлов:EnumBase
    {
        public ФорматыХраненияОдностраничныхФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem BMP => GetProperty<EnumItem>("BMP");
        public EnumItem GIF => GetProperty<EnumItem>("GIF");
        public EnumItem JPG => GetProperty<EnumItem>("JPG");
        public EnumItem PDF => GetProperty<EnumItem>("PDF");
        public EnumItem PNG => GetProperty<EnumItem>("PNG");
        public EnumItem TIF => GetProperty<EnumItem>("TIF");
    }
}
